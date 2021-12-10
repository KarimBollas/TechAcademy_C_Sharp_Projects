using System;
using System.Collections.Generic;
using System.IO;
using Casino;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne

{
    class Program
    {
        
        static void Main(string[] args)
        {
            const string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            const string casinoName = "Grand Hotel Casino";
            Player newPLayer = new Player("Karim");
            Guid identifier = Guid.NewGuid();

            //string someText = "This is some text.";
            //File.WriteAllText(@"C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\MyClassesSolution\TwentyOne\Logs\log.txt",someText);

            Console.WriteLine("WELCOME to the {0}.\nLet's start by telling me your name",casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower()=="admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions(connectionString);
                foreach (ExceptionEntity exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp+" | ");
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }
            bool validAnswer = false;
            int bank = 0;

            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer)
                {
                    Console.WriteLine("Type digits only, no decimals.");
                }
            }

                    
            
            Console.WriteLine("Hello, {0}. Dou ypu wnat to join a game of 21 rigth now?", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah"|| answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName,bank);
                player.Id = Guid.NewGuid();
                Game game = new TwentyOneGame();
                
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException ex)
                    {
                        
                        Console.WriteLine("{0}\nSecurity! Kick this person out.",ex.Message);
                        UpdateDbWithException(ex, connectionString);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error, please contact your System Administratr.\n{0}", ex.Message);
                        UpdateDbWithException(ex, connectionString);
                        Console.ReadLine();
                        return;
                    }

                    
                }
                
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            
            Console.WriteLine("Feel free to look around the casino. By for now.");
            Console.Read();
        }
        
        private static void UpdateDbWithException(Exception exception, string connectionString)
        {
            
            string queryString = "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES " +
                                    "(@ExceptionType, @ExceptionMessage, @TimeStamp);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp",SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = exception.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = exception.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
                                    
        }
        private static List<ExceptionEntity> ReadExceptions(string connectionString)
        {
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions;";
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = (DateTime)reader["TimeStamp"];
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;

        }

    }
}

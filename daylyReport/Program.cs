using System;

namespace daylyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Banner
            string banner =""+
                "                  T H E    T E C H    A C A D E M Y\r\n"+
                "    ^^      ..                                       .. \r\n" +
                "            []                                       [] \r\n" +
                "          .:[]:_          ^^                       ,:[]:.\r\n" +
                "        .: :[]: :-.                             ,-: :[]: :.\r\n" +
                "      .: : :[]: : :`._                       ,.': : :[]: : :.\r\n" +
                "    .: : : :[]: : : : :-._               _,-: : : : :[]: : : :.\r\n" +
                "_..: : : : :[]: : : : : : :-._________.-: : : : : : :[]: : : : :-._\r\n" +
                "_:_:_:_:_:_:[]:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:[]:_:_:_:_:_:_\r\n" +
                "!!!!!!!!!!!![]!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!![]!!!!!!!!!!!!!\r\n" +
                "^^^^^^^^^^^^[]^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^[]^^^^^^^^^^^^^\r\n" +
                "            []                                       []\r\n" +
                "            []                                       []\r\n" +
                "            []                                       []\r\n" +
                " ~~^-~^_~^~/  \\~^-~^~_~^-~_^~-^~_^~~-^~_~^~-~_~-^~_^/  \\~^-~_~^-~~-\r\n" +
                "~ _~~- ~^-^~-^~~- ^~_^-^~~_ -~^_ -~_-~~^- _~~_~-^_ ~^-^~~-_^-~ ~^\r\n" +
                "   ~ ^- _~~_-  ~~ _ ~  ^~  - ~~^ _ -  ^~-  ~ _  ~~^  - ~_   - ~^_~\r\n" +
                "     ~-  ^_  ~^ -  ^~ _ - ~^~ _   _~^~-  _ ~~^ - _ ~ - _ ~~^ -\r\n" +
                "        ~^ -_ ~^^ -_ ~ _ - _ ~^~-  _~ -_   ~- _ ~^ _ -  ~ ^-\r\n\r\n\r\n\r\n";
            Console.WriteLine(banner);                      // print Banner
            Console.WriteLine("What is your name?");        // ask Name
            string name = Console.ReadLine();                  //read Name
            Console.WriteLine("What course are you on?");      // ask Course      
            string course = Console.ReadLine();                 //read Course
            Console.WriteLine("What page number?");             //ask page
            int page = Convert.ToInt32(Console.ReadLine());     // cast page to int from input read 
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”"); // ask help true or false
            bool needHelp = Convert.ToBoolean(Console.ReadLine());                                  // cast help to bool from input read, it crashes if not true or false
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics."); // ask experiences
            string experiences = Console.ReadLine();           // read experiences                      
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");  //ask for feedback
            string feedback = Console.ReadLine();               //read feedback
            Console.WriteLine("How many hours did you study today?"); //ask hours of study
            int hoursStudy = Convert.ToInt32(Console.ReadLine());       //cast hours of study to int from input read

            Console.WriteLine("\n\n Thank you for your answers. \n\rAn Instructor will respond to this shortly. \r\nHave a great day!");
            Console.ReadLine();
        }
    }
}

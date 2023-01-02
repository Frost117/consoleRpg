namespace ConsoleRpg.GUI
{
    class Gui
    {
        public static void Title(String str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            str = String.Format("==== {0} ====\n\n", str);
            
            Console.Write(str);
            Console.ResetColor();
        }

        public static void MenuOption(int index, String str)
        {
            str = String.Format(" - ({0}) : {1}\n", index, str);

            Console.Write(str);
        }
        public static void MenuTitle(String str)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            str = String.Format("\t==== {0} ====\n", str);

            Console.Write(str);
            Console.ResetColor();
        }
        public static void Notification(String str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            str = String.Format("\t {0}!\n", str);

            Console.Write(str);
            Console.ResetColor();
        }

        public static String ProgressBar(int min, int max, int width = 10)
        {
            String bar = "[";

            double percent = (double)min / max;
            int complete = Convert.ToInt32(percent * width);
            int incomplete = width - complete;

            for (int i = 0; i < complete; i++)
            {
                bar += "=";
            }
            for (int i = complete; i < width; i++)
            {
                bar += "-";
            }
            bar += "]";

            return bar;
        }


        public static void GetInput(String str)
        {
            str = String.Format(" - {0}: \n", str);

            Console.Write(str);
        }

        public static int GetInputInt(string msg)
        {
            Nullable<int> input = null;

            while(input == null) 
            { 
                try 
                {
                    GetInput(msg);
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return input.Value;
        }
    }
}

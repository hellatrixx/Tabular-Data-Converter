using System;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace myApp
{
    
    class Program
    {

        //Command Line Parser
        public static void Args(string[] args)
         {

            foreach (string arg in args)
            {
                switch (arg) {
                    case "-h":
                    case "--help":
                        Console.WriteLine("Help");
                        break; 
                    
                    case "-l":
                    case "--list-formats":
                        Console.WriteLine("CSV, JSON, MD, HTML");
                        break;
                    
                    case "-i":
                    case "--info":
                        Console.WriteLine("The version of the currently executing assembly is: {0}", typeof(Program).Assembly.GetName().Version);
                        break;

                    case "-v":
                    case "--verbose":
                        Console.WriteLine("Standard Output Stream: {0}", Console.Out);
                        //Debug.WriteLine("Debugging Output Stream: {0}", Console.Out);
                        break;

                    case "-o":
                    case "--output":
                        //Console.WriteLine(jsonTable());
                        Console.WriteLine(checkFile(args));
                        break;
                } 
            } 
         }


        /* public enum tablesFormat
        {
            None = 0,
            JSON = 1
        } */
         

         public static string checkFile(string[] args)
         {
            string inputTable = "";
            string fileName = args[0];
            if (File.Exists(fileName))
            {
                inputTable = File.ReadAllText(fileName);
                return inputTable;
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            return inputTable;
         }
         
         
         
         public static string jsonTable ()
         {
            string jsonTableData = File.ReadAllText("table.json");
            return jsonTableData;
         }   





        static void Main(string[] args)
        {
            
            Program.Args(args);
        
            
        }
    }
}

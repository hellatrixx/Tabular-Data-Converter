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

         

         public static string checkFile(string[] args)
         {
            string inputTable = "";
            string fileName = args[0];
            if (File.Exists(fileName))
            {
                inputTable = File.ReadAllText(fileName);
                string table = inputTable.ToString();
                Console.WriteLine(tableMaker(table));
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            return inputTable;
         }

         public static DataTable tableMaker(string table)
         {
            DataTable dt = new DataTable();
            string[] rows = table.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string[] headers = rows[0].Split(',');
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }
            for (int i = 1; i < rows.Length; i++)
            {
                string[] row = rows[i].Split(',');
                DataRow dr = dt.NewRow();
                for (int j = 0; j < row.Length; j++)
                {
                    dr[j] = row[j];
                }
                dt.Rows.Add(dr);
            }
            return dt;
         }
        
         
        





        static void Main(string[] args)
        {
            
            Program.Args(args);
        
            
        }
    }
}

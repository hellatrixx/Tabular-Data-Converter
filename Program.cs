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
            string argInput = args[0].Split('.')[1];
            string argOutput = args[2].Split('.')[1];


            foreach (string arg in args)
            {
    
                switch (arg) {
                    case "-h":
                    case "--help":
                        Console.WriteLine("-v,	—verbose  Verbose mode (debugging output to	STDOUT), -o	<file>,	—output=<file> Output file specified by	<file>, -l,	—list-formats List formats, -h,	—help Show usage message, -i,	—info Show version information");
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
                        if(argInput == "csv" && argOutput == "md")
                        {
                            mdTable();
                        }
                        if(argInput == "csv" && argOutput == "json")
                        {
                            jsonTable();
                        }
                        if(argInput == "csv" && argOutput == "html")
                        {
                            htmlTable();
                        }
                        if(argInput == "md" && argOutput == "csv")
                        {
                            csvTable();
                        }
                        if(argInput == "md" && argOutput == "json")
                        {
                            jsonTable();
                        }
                        if(argInput == "md" && argOutput == "html")
                        {
                            htmlTable();
                        }
                        if(argInput == "html" && argOutput == "md")
                        {
                            mdTable();
                        }
                        if(argInput == "html" && argOutput == "csv")
                        {
                            csvTable();
                        }
                        if(argInput == "html" && argOutput == "json")
                        {
                            jsonTable();
                        }
                        if(argInput == "json" && argOutput == "csv")
                        {
                            csvTable();
                        }
                        if(argInput == "json" && argOutput == "md")
                        {
                            mdTable();
                        }
                        if(argInput == "json" && argOutput == "html")
                        {
                            htmlTable();
                        }
                        break; 
                } 
            } 
         }


 /*        public static string checkFile(string[] args)
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
         } */



         public static void csvTable()
         {
            string inputTable = File.ReadAllText("C:\\Users\\stili\\VS projects\\C#\\myApp\\table.csv");
            string table = inputTable.ToString();
            DataTable csvMidTable = new DataTable();
            string[] rows = inputTable.Split(new string[] {Environment.NewLine}, StringSplitOptions.None);
            string[] headers = rows[0].Split(',');
            foreach (string header in headers)
            {
                csvMidTable.Columns.Add(header);
            }
            for(int i = 1; i < rows.Length; i++)
            {
                string[] data = rows[i].Split(',');
                DataRow dr = csvMidTable.NewRow();
                for (int j = 0; j < data.Length; j++)
                {
                    dr[j] = data[j];
                }
                csvMidTable.Rows.Add(dr);
            }
            
            

            foreach (DataRow dr in csvMidTable.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item + " ");
                }
             Console.WriteLine();
            }
        }
        
        
        public static void jsonTable()
         {
            string inputTable = File.ReadAllText("C:\\Users\\stili\\VS projects\\C#\\myApp\\table.json");
            DataTable jsonMidTable = new DataTable();
            string[] rows = inputTable.Split(new string[] {Environment.NewLine}, StringSplitOptions.None);
            string[] headers = rows[0].Split(',');
            foreach (string header in headers)
            {
                jsonMidTable.Columns.Add(header);
            }
            for(int i = 1; i < rows.Length; i++)
            {
                string[] data = rows[i].Split(',');
                DataRow dr = jsonMidTable.NewRow();
                for (int j = 0; j < data.Length; j++)
                {
                    dr[j] = data[j];
                }
                jsonMidTable.Rows.Add(dr);
            }
            foreach (DataRow dr in jsonMidTable.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item + " ");
                }
             Console.WriteLine();
            }
         }

         public static void mdTable()
         {
            string inputTable = File.ReadAllText("C:\\Users\\stili\\VS projects\\C#\\myApp\\table.md");
            string table = inputTable.ToString();
            DataTable csvMidTable = new DataTable();
            string[] rows = inputTable.Split(new string[] {Environment.NewLine}, StringSplitOptions.None);
            string[] headers = rows[0].Split(',');
            foreach (string header in headers)
            {
                csvMidTable.Columns.Add(header);
            }
            for(int i = 1; i < rows.Length; i++)
            {
                string[] data = rows[i].Split(',');
                DataRow dr = csvMidTable.NewRow();
                for (int j = 0; j < data.Length; j++)
                {
                    dr[j] = data[j];
                }
                csvMidTable.Rows.Add(dr);
            }
            
            

            foreach (DataRow dr in csvMidTable.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item + " ");
                }
             Console.WriteLine();
            }
        }

        public static void htmlTable()
         {
            string inputTable = File.ReadAllText("C:\\Users\\stili\\VS projects\\C#\\myApp\\table.html");
            string table = inputTable.ToString();
            DataTable csvMidTable = new DataTable();
            string[] rows = inputTable.Split(new string[] {Environment.NewLine}, StringSplitOptions.None);
            string[] headers = rows[0].Split(',');
            foreach (string header in headers)
            {
                csvMidTable.Columns.Add(header);
            }
            for(int i = 1; i < rows.Length; i++)
            {
                string[] data = rows[i].Split(',');
                DataRow dr = csvMidTable.NewRow();
                for (int j = 0; j < data.Length; j++)
                {
                    dr[j] = data[j];
                }
                csvMidTable.Rows.Add(dr);
            }
            
            

            foreach (DataRow dr in csvMidTable.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item + " ");
                }
             Console.WriteLine();
            }
        }

        


/*         public static DataTable tableMaker(string table)
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
         } */
        
         
        





        static void Main(string[] args)
        {
            
            Program.Args(args);
        
            
        }
    }
}

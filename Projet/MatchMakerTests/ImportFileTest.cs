using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace MatchMakerTests
{
    [TestClass]
    public class ImportFileTest
    {

        [TestMethod]
        public void ImportFileTest1()
        {

        }
        void ImportCSV()
        {
            //Set path of CSV file
            string Path = Directory.GetCurrentDirectory();
            string csvPath = Path + "TestData.csv";
            //Read the contents of CSV file.  
            string csvData = File.ReadAllText(csvPath);

            //Execute a loop over the rows.  
            string[,] csvTable = new string[15,100];
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    csvTable.Rows.Add();
                    int i = 0;

                    //Execute a loop over the columns.  
                    foreach (string cell in row.Split(','))
                    {
                        csvTable.Rows[csvTable.Rows.Count - 1][i] = cell;
                        i++;
                    }
                }
            }
        }
    }
}

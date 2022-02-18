using System;
using System.IO;

namespace PatientRecordApplication
{
     class PatientRecord
     {
          
          public void BalNen()
          {
               Console.Clear();

               Console.Write("Please enter the balance: ");

               decimal pointBal = 0M;

               //Format Exception
               try
               {
                    pointBal = decimal.Parse(Console.ReadLine());
               }
               catch (System.FormatException)
               {
                    Console.WriteLine("Please re-enter invalid value.");
               }

               FileStream inFile = new FileStream(File, FileMode.Open, FileAccess.Read);
               StreamReader reader = new StreamReader(inFile);

               string toLine = reader.ReadLine();

               string[] getInfo;

               Console.Clear();
               Console.WriteLine(toLine);
               

               //format exception
               while (toLine != null)
               {
                    getInfo = toLine.Split(' ');

                    try
                    {
                         if (decimal.Parse(getInfo[2]) >= pointBal)
                         {
                              Console.WriteLine(toLine);
                         }
                    }
                    catch (System.FormatException)
                    {

                    }
                    toLine = reader.ReadLine();
               }

               reader.Close();
               inFile.Close();
          }
          //getters and settors
          public string File { get; set; }

          public PatientRecord()
          {

          }

          public PatientRecord(string file)
          {
               File = file;
          }
          
          public void LookID()
          {    //search by ID
              Console.Clear();

               Console.Write("Please enter the ID number: ");
               string id = Console.ReadLine();

               FileStream inFile = new FileStream(File, FileMode.Open, FileAccess.Read);
               StreamReader reader = new StreamReader(inFile);

               string toLine = reader.ReadLine();
               string[] getInfo;

               Console.Clear();
               Console.WriteLine(toLine);

               while (toLine != null)
               {
                    getInfo = toLine.Split(' ');

                    if (getInfo[0] == id)
                    {
                         Console.WriteLine(toLine);
                    }

                    toLine = reader.ReadLine();
               }

               reader.Close();
               inFile.Close();
          }
     }
}

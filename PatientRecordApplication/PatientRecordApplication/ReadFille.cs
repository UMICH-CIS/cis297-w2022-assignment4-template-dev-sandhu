using System;
using System.IO;

namespace PatientRecordApplication
{
     //constructors
     class ReadFille
     {
           
          public ReadFille()
          {

          }
          //getters and settors
          public string File { get; set; }

          public ReadFille(string file)
          {
               File = file;
          }
          //reading from the file
          public void ReadFil()
          {
               Console.Clear();

               FileStream inFile = new FileStream(File, FileMode.Open, FileAccess.Read);

               StreamReader reader = new StreamReader(inFile);

               string currentLine = reader.ReadLine();

               while (currentLine != null)
               {
                    Console.WriteLine(currentLine);

                    currentLine = reader.ReadLine();
               }

               reader.Close();

               inFile.Close();
          }
     }
}

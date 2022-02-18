using System;
using System.IO;

namespace PatientRecordApplication
  
{
     class WriteFile
     {    //getters and settors
          public string File { get; set; }
          public WriteFile()
          {

          }
          public WriteFile(string file)
          {
               File = file;
          }

          public void NewPatient()
          {    //input to add new patient and information to file
               Console.Clear();

               PatientClass patient = new PatientClass();

               Console.Write("Please enter the name: ");
               patient.Name = Console.ReadLine();

               Console.Write("Please enter the ID: ");
               patient.NumID = Console.ReadLine();

               Console.Write("Please enter the due balance: ");

               patient.BalLeft = decimal.Parse(Console.ReadLine());
            
               FileStream outFile = new FileStream(File, FileMode.Append, FileAccess.Write);

               StreamWriter writer = new StreamWriter(outFile);
               writer.WriteLine($"{patient.NumID} {patient.Name} {patient.BalLeft}");

               writer.Close();
               outFile.Close();
          }
     }
}

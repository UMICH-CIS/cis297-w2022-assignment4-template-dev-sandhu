/// <summary>
/// Patient Info Record System.
/// </summary>
/// <Student>Gurnoor Singh Sandhu</Student>
/// <Class>CIS297</Class>
/// <Assignment>#4</Assignment>
/// <Semester>Winter 2022</Semester>

using System;

namespace PatientRecordApplication
{
     class Program
    {
          static void Main(string[] args)
          {
               //user input for main file to store data
               Console.WriteLine("************Patient Record Application************************\n");
               Console.Write("Please enter the file name to store patient's information: ");
               string file = Console.ReadLine() + ".txt";
               Console.WriteLine();
               Console.WriteLine("**************************************************************\n");

               WriteFile writeFile = new WriteFile(file);
               ReadFille readFile = new ReadFille(file);

               PatientRecord patientRecord = new PatientRecord(file);

               while (true)
               { //switch statement to make program running till user exits it 
                    switch (ConOption())
                    {
                         case 1:
                              writeFile.NewPatient();
                              break;

                         case 2:
                              readFile.ReadFil();
                              break;

                         case 3:
                              patientRecord.LookID();
                              break;

                         case 4:
                              patientRecord.BalNen();
                              break;

                         case 5:
                              return;

                         default:
                              break;
                    }

                    Console.WriteLine("Please press enter to continue.");
                    Console.ReadLine();
               }
          }

          public static int ConOption()
          {
               //main menu to display on console
               Console.WriteLine("Please select from the options below\n");
               Console.WriteLine("1 to Add a new patient to the file.");
               Console.WriteLine("2 to search the patient by ID.");
               Console.WriteLine("3 to find the patients having minimun due balance.");
               Console.WriteLine("4 to display file.");
               Console.WriteLine("5 to exit out of the program");
             
               int userVal = 0;

               //user input
               Console.Write("\nInput: ");
               userVal = int.Parse(Console.ReadLine());

               return userVal;
          }
         


     }

}


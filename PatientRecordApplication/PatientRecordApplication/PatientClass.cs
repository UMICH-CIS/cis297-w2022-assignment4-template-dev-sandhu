namespace PatientRecordApplication
{
     class PatientClass
     {
          //constructor
          public PatientClass()
          {

          }
          //getters and settors
          public string Name { get; set; }
          public string NumID { get; set; }
          private decimal balLeft;

          public PatientClass(string id, string name, decimal ball)
          {
               NumID = id;
               Name = name;
               BalLeft = ball;
          }

          public decimal BalLeft
          {
               get => balLeft;

               //system exception
               set
               {
                    if (value >= 0)
                    {
                         balLeft = value;
                    }
                    else
                    {
                         throw new System.Exception();
                    }
               }
          }
     }
}

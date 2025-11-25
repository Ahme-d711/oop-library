abstract  class Person
{
   public int ID { get; set; }
   private string Name;
 
   public string name 
   { 
   get { return Name; }

       set
       {
           if (value == "")
               Name = "Unknown";
           else
               Name = value;
       }
   }




   public Person(string name, int Id)
   {
       Name = name;
    ID = Id;
       
   }

   public abstract string GetInfo();
 
}
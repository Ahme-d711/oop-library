 class StudentMember : Person
 {
     public double Grade;

     public StudentMember(string name, int id, double grade) : base(name, id)
     {
         Grade = grade;
     }

     public override string GetInfo() 
     {
         return $"Name: {name}, ID: {ID}, Grade: {Grade}";

     }

 }
class TeacherMember : Person 
{
    private string _Department;

    public string department
    {
        get { return _Department; }
       set 
       {
          if (value == "")
                _Department = "Unknown";
         else
               _Department = value;
       }

    }

    public TeacherMember(string name, int Id, string depart) : base(name, Id)
    {
        _Department = depart;
    }
    public override string GetInfo()
    {
        return $"Name: {name}, ID: {ID}, Department {_Department}";
    }
}
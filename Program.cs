using System;

namespace small_Libray_Management
{
    // class number 1
    abstract class Person
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

    // Class number 2
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

    // Class 3
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
            return $"Name: {name}, ID: {ID}, Department: {_Department}";
        }
    }

    //class number 4
    class BOOK
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public bool IsAvailable { get; private set; } = true;

        public BOOK(int bookID, string title, string author, bool isavailable)
        {
            BookId = bookID;
            Title = title;
            Author = author;
            IsAvailable = isavailable;
        }

        public bool Borrow()
        {
            if (!IsAvailable)
            {
                return false;
            }
            else
            {
                IsAvailable = false;
                return true;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

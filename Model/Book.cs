 class BOOK 
 {
     public int BookId { get; set; }
     public string Title { get; set; }
     public string Author { get; set; }

     // التعديل مسموح اذا كان داخل الكلاس فقط 
     public bool IsAvailable { get;private set; } = true;
     public BOOK(int bookID, string title, string author, bool isavailable) 
     {
      BookId = bookID;   Title = title;     Author = author;    IsAvailable = isavailable;
     }

     public bool Borrow()
     {
         //اذا كان الكتاب غير موجود
         if (!IsAvailable) 
         { return false; }
         else
         {
             // هنا لما هتكون IsAvailable بي false ,  true  هيلاقي! فهتبقىfalse هيرجع لللشرط الي فوق وهيحط ال 
             IsAvailable = false;
             return true;
         }
     }
 }
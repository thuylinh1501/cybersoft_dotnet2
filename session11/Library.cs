class Library{
    public string libraryId;
    public string libraryName;
    public List<Book> books;
    public Library(string libraryId, string libraryName){
        this.libraryId = libraryId;
        this.libraryName = libraryName;
        this.books = new List<Book>();
    }

    public void addBook(Book book){
        books.Add(book);
        Console.WriteLine($"Book: {book.bookName} add to Library {libraryName}");
    }

    public void showBook(){;
        Console.WriteLine($"\n-----Books in library {libraryName}-----");
        foreach(Book book in books){
            book.displayInfo();
        }
    }

    // Phương thức tìm kiếm sinh viên theo mã sinh viên
    public void findBookByBookID(string bookId){;
        // C1: Dùng vòng lặp
        foreach(Book book in books){
            if(book.bookId == bookId){
                book.displayInfo();
                return;
            }
        }
        Console.WriteLine($"Book with ID: {bookId} not found in library {libraryName}");
    }
}
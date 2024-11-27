class Book{
    public string bookId;
    public string bookName;
    public string author;
    public double price;
    public void Student(string bookId, string bookName,string author, double price){
        this.bookId = bookId;
        this.bookName = bookName;
        this.author = author;
        this.price = price;
    }
    public void displayInfo(){
        Console.WriteLine($"Book ID: {bookId}, Book's Name: {bookName}, Author: {author}, Price: {price}");
    }
}
class Product {
    private int productId;
    public int ProductId
    {
        get { return productId; }
        set{ 
            if (value < 0) {
                throw new ArgumentException("ID must be greater than 0");
            }
            productId = value;
        }
    }
    // exception
    //
    // 1. Lỗi logic và tham số (ArgumentException,...)
    // 2. Lỗi dữ liệu (FormatException,...)
    // 3. Lỗi hệ thống
    // 4. Lỗi I/O và mạng
    // 5. Lỗi luồng và đa nhiệm
    private string productName;
    public string ProductName
    {
        get { return productName; }
        set{ 
            if (string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("Product name must not be empty!");
            }
            productName = value;
        }
    }
    private double price;
    public double Price
    {
        get { return price; }
        set{ 
            if (value < 0){
                throw new ArgumentException("Price must be greater than 0!");
            }
            price = value;
        }
    }
    private string description;
    public string Description
    {
        get { return description; }
        set{ 
            if (string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("Product must not be empty!");
            }
            description = value;
        }
    }
    public Product(int productId, string productName, double price, string description){
        ProductId = productId;
        ProductName = productName;
        Price = price;
        Description = description;
    }

    public virtual void displayInfo(){
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product name: {ProductName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Description: {Description}");
    }
}
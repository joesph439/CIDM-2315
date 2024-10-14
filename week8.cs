namespace Week8;

class Program
{
    static void Main(string[] args){
    
        Student Alice = new Student(input_id:111, input_age:23, input_name:"Alice Smith");
        //Alice.id = 1111;
        //Alice.age = 23;
        //Alice.name = "Alice Smith";
        Alice.printInfo();
        Student Bob = new Student();
        Bob.printInfo();
        
        Customer cus1 = new Customer(inputCustomerName: "Alice");
        Console.WriteLine($"No. of Customer: {Customer.countCustomer}");
        Customer cus2 = new Customer(inputCustomerName: "Bob");
        Console.WriteLine($"No. of Customer: {Customer.countCustomer}");
      

    }
}

class Student{
    public int id = 0;
    public int age = 0;
    public string name = string.Empty;
    public void printInfo(){
        Console.WriteLine($"Student ID: {id}");
        Console.WriteLine($"Student name: {name}");
        Console.WriteLine($"Student age: {age}");
    }
    public Student(int input_id, int input_age, string input_name){
        //Console.WriteLine("Constructor: an empty object is created!");
        id = input_id;
        age = input_age;
        name = input_name;
    }
    public Student(){
        Console.WriteLine("Create An Empty Object");
    }
}
class Customer{
    public static int countCustomer {get; set;} = 0;
    public string customerName {get; set;} = string.Empty;
    public Customer(string inputCustomerName){
        customerName = inputCustomerName;
        Console.WriteLine($"Customer {inputCustomerName} created!");
        countCustomer +=1;
    }
}
class Computer{
    public int price {get;set;} = 0;
    public string brand {get;set;} = string.Empty;
    public Computer(int price, string brand){
        this.price = price;
        this.brand = brand;
    }

    public void ComparePrice(Computer objComputer)
}

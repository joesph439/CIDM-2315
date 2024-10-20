namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        // Answer Q1 and Q2
        Customer c1 = new Customer(cus_id:110, cus_age: 28, cus_name:"Alice");
        c1.PrintCusInfo();
        Customer c2 = new Customer(cus_id:111, cus_age:30, cus_name:"Bob");
        c2.PrintCusInfo();
        c1.ChangeID(220);
        c2.ChangeID(221);
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        c1.CompareAge(c2);
    }
}

class Customer{
    // Code for Customer Class
    private int id = 0;
    public string name = string.Empty;
    public int age = 0;
    public Customer(int cus_id, string cus_name, int cus_age){
        id = cus_id;
        age = cus_age;
        name = cus_name;
    }
    public void ChangeID(int new_id){
        id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {id}, name: {name}, age: {age}");
    }
    public void CompareAge(Customer objCustomer){
        if(this.age >= objCustomer.age){
            Console.WriteLine($"{this.name} is older");
        }
        else{
            Console.WriteLine($"{objCustomer.name} is older");
        }
    }
}

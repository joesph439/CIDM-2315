using System.Reflection;

namespace HW8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
        Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
        Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
        Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
        Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);

 	    Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

        //Call Q1 method
        TotalCredits(customer_list);
        // Call Q2 method
        AmarilloAverageAge(customer_list);
        //Call Q3 method
        CanyonAge(customer_list);
    }
    // Q1. Create a method to calculate and print the total credit of all customers in the customer_list.
    public static void TotalCredits(Customer[] customer_list){
        //To be implemented
        double totalCredits = 0;
        foreach(Customer customerItem in customer_list){
            totalCredits += customerItem.customerCredit;
        }
        Console.WriteLine($"Q1: The total credits: {totalCredits}");
    }
    public static void AmarilloAverageAge(Customer[] customer_list){
        double totalCredits = 0;
        int countCredit = 0;
        foreach(var customerItem in customer_list){
            totalCredits += customerItem.customerCredit;
            countCredit++;
        }
        if(countCredit > 0){
            double amarilloAverageAge = totalCredits/countCredit;
            Console.WriteLine($"Q2: The average age of customers in Amarillo: {amarilloAverageAge}");
        }

    }
    public static void CanyonAge(Customer[] customer_list){
        Console.Write("Customers who live in Canyon and over 30 years old: ");
        foreach(var cus in customer_list){
            if((cus.customerCity == "Canyon") && (cus.customerAge>30)){
                Console.Write($"{cus.customerName},");
            }
        }
    }
}

//Q0: Create a class called customer
class Customer{
    //To be implemented
    public string customerName {get;set;} = string.Empty;
    public int customerAge {get;set;} = 0;
    public string customerCity{get;set;} = string.Empty;
    public double customerCredit{get;set;} = 0;

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}

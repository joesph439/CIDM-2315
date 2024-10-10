namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Answer Q1 
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        Console.WriteLine($"Professor {p1.profName} teaches {p1.classTeach}, and the salary is: {p1.GetSalary()}");
        
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        Console.WriteLine($"Professor {p2.profName} teaches {p2.classTeach}, and the salary is: {p2.GetSalary()}");
        
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        Console.WriteLine($"Student {s1.studentName} enrolls {s1.classEnroll}, and the grade is: {s1.GetGrade()}");

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        Console.WriteLine($"Student {s2.studentName} enrolls {s2.classEnroll}, and the grade is: {s2.GetGrade()}");

        //Answer Q2
        Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {p1.GetSalary() - p2.GetSalary()}");
        Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {s1.GetGrade() + s2.GetGrade()}");
    }
}

class Professor
{
    //Code for Professor Class
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }

    public double GetSalary(){
        return salary;
    }

}

class Student
{
    //Code for Student Class
    public string studentName;
    public string classEnroll;
    private double studentGrade {get; set;}

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }

    public double GetGrade(){
        return studentGrade;
    }
}

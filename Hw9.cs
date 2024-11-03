namespace HW9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student Bob = new Student(222, "Bob");
        Student Cathy = new Student(333, "Cathy");
        Student David = new Student(444, "David");

        foreach(Student student in Student.student_list){
            student.PrintInfo();
        }

        Dictionary<double, string> gradebook = new Dictionary<double, string>();
        gradebook.Add(4.0,"Alice");
        gradebook.Add(3.6, "Bob");
        gradebook.Add(2.5, "Cathy");
        gradebook.Add(1.8, "David");

        if(!gradebook.ContainsKey(3.3)){
            gradebook.Add(3.3, "Tom");
        }
        double totalGPA = 0;
        foreach(var student in gradebook){
            totalGPA += Student.Value;
        }
        double avgGPA = totalGPA/gradebook.Count;
        Console.WriteLine("The average GPA is: "+avgGPA);

// iterate student in student_list, check find student whose GPA >averageGPA
        foreach(var stuObj in Student.student_list){
            if(gradebook[stuObj.studentName]>avgGPA){
                stuObj.PrintInfo();
            }
        }
    }

}
class Student{
    private int studentID {get; set;}
    private string studentName{ get; set;}
    public void PrintInfo(){
        Console.WriteLine($" Student ID: {studentID}, Student Name: {studentName}");
    }
    public static List<Student> student_list = new List<Student>();
    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }
}

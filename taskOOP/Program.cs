
// See https://aka.ms/new-console-template for more information

//C# OOP

//Task 1:

public class Student
{
    // Properties
    public string Name { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }

    // Constructor
    public Student(string name, string major, double gpa)
    {
        Name = name;
        Major = major;
        GPA = gpa;
    }

    // Task 2: 
    // Method to print the student's summary
    public void PrintSummary()
    {
        Console.WriteLine("Student information:\n");
        Console.WriteLine($"Student Name:\t {Name} \nMajor:\t\t {Major} \nGPA:\t\t {GPA:F3}"); // F3 means format GPA to 2 decimal places
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new student object
        Student student = new Student("Saleh Bin Essa", "IST", 3.404);

        // Print the student's summary
        student.PrintSummary();
        Console.WriteLine("----------------------------------------");
        // Create a new Graduate Student object
        GraduateStudent grad = new GraduateStudent("Ahmad Salman", "Artificial Intelligence", 3.9, "Augmented Reality");
        
        // Print the student's summary
        grad.PrintSummary();
    }
}


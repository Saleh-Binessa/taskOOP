
// See https://aka.ms/new-console-template for more information

//C# OOP

// Bonus:
public class GraduateStudent : Student
{
    public string ResearchTopic { get; set; }

    public GraduateStudent(string name, string major, double gpa, string researchTopic)
        : base(name, major, gpa) 
    {
        ResearchTopic = researchTopic;
    }

    public new void PrintSummary()
    {
        Console.WriteLine("Alumni information:-\n");
        base.PrintSummary(); 
        Console.WriteLine($"Research Topic: {ResearchTopic}");
    }
}


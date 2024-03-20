using System.IO;
class Program
{
    static List<double> grades = new List<double>();

    static void Main()
    {
        string input;
        double grade;

        Console.WriteLine("Enter grades (-3-12), type -1 to stop:");

        while (true)
        {
            input = Console.ReadLine();

            if (double.TryParse(input, out grade))
            {
                if (grade == -1)
                {
                    break;
                }
                else if (grade >= -3 && grade <= 12)
                {
                    grades.Add(grade);
                }
                else
                {
                    Console.WriteLine("Invalid grade. Please enter a grade between -3 and 12.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        SaveStatistics();

        if (grades.Count > 0)
        {
            double lowestGrade = grades.Min();
            double highestGrade = grades.Max();
            double averageGrade = grades.Average();

            Console.WriteLine($"Lowest grade: {lowestGrade}");
            Console.WriteLine($"Highest grade: {highestGrade}");
            Console.WriteLine($"Average grade: {averageGrade}");
        }
        else
        {
            Console.WriteLine("No grades were entered.");
        }
    }
  
    static void SaveStatistics()
    {
        using (StreamWriter writer = new StreamWriter("C:\\Karakterbog.txt"))
        {
            writer.WriteLine("Lowest grade: " + grades.Min());
            writer.WriteLine("Highest grade: " + grades.Max());
            writer.WriteLine("Average grade: " + grades.Average());
        }
    }
}
INSERT INTO karater (Lowest grade, Highest grade, Average grade)
VALUES (
    Lowest grade:int,
    Highest grade:int,
    Average grade:int
  );

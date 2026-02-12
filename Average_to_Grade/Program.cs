using System;
class AverageToGrade
{
    static void Main()
    {
        Console.WriteLine("====Welcome to Average to Grade====");

        int[] marks = new int[5];

        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine($"Enter the marks{i + 1} number");
            while (!int.TryParse(Console.ReadLine(),out marks[i]))
            {
                Console.WriteLine("Invalid inputt");
                
            }
        }

        int sum = 0;
        foreach (int mark in marks)
        {
            sum += mark;
        }
        double average = (double)sum / marks.Length;

        string grade;
        if (average >= 90)
            grade = "A+";
        else if(average>=80)
            grade = "A";
        else if(average >=70)
            grade = "B+";
        else if(average >=60)
            grade = "B";
        else if(average >=50)
            grade = "C+";
        else if (average >= 40)
            grade = "C";
        else
            grade = "F";
        
        Console.WriteLine("====Result from  Average to Grade==== ");
        Console.WriteLine($"Total Marks: {sum}/500");
        Console.WriteLine($"Average Marks: {average:F2}");
        Console.WriteLine($"Grade: {grade}");
        
            
    }
}
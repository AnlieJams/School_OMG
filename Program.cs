using System;

class Student
{
    public string Name { get; }
    public double AverageScore { get; }

    public Student(string name, double averageScore)
    {
        Name = name;
        AverageScore = averageScore;
    }

   
    public static bool operator ==(Student student1, Student student2)
    {
        return student1.AverageScore == student2.AverageScore;
    }

    
    public static bool operator !=(Student student1, Student student2)
    {
        return student1.AverageScore != student2.AverageScore;
    }

    
    public static bool operator >(Student student1, Student student2)
    {
        return student1.AverageScore > student2.AverageScore;
    }

  
    public static bool operator <(Student student1, Student student2)
    {
        return student1.AverageScore < student2.AverageScore;
    }

  
    public static bool operator >=(Student student1, Student student2)
    {
        return student1.AverageScore >= student2.AverageScore;
    }

    
    public static bool operator <=(Student student1, Student student2)
    {
        return student1.AverageScore <= student2.AverageScore;
    }

    public static implicit operator bool(Student student)
    {
        return student.AverageScore >= 7.0;
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Мимик", 8.0);
        Student student2 = new Student("Папа", 6.5);

        if (student1)
        {
            Console.WriteLine("Студент 1 рил (средняя оценка >= 7)");
      
        }
        else
        {
            Console.WriteLine("Студент 1 фэйк (средняя оценка < 7)");
        }

        if (student2)
        {
            Console.WriteLine("Студент 2 рил (средняя оценка >= 7)");
        }
        else
        {
            Console.WriteLine("Студент 1 фэйк (средняя оценка < 7)");
        }

        if (student1 > student2)
        {
            Console.WriteLine("Студент 1 имеет высшую среднюю оценку, чем Студент 2");
        }
        else if (student1 < student2)
        {
            Console.WriteLine("Студент 2 имеет высшую среднюю оценку, чем Студент 1");
        }
        else
        {
            Console.WriteLine("Студент 1 и Студент 2 имеют одинаковую среднюю оценку");
        }
    }
}

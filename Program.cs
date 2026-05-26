using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Group { get; set; }

    public Student(int id, string fullName, string group)
    {
        Id = id;
        FullName = fullName;
        Group = group;
    }

    public override bool Equals(object obj)
    {
        return obj is Student student && Id == student.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class CourseProgress
{
    public string CourseName { get; set; }
    public double CurrentScore { get; set; }
    public int CompletedTopics { get; set; }
    public string CurrentTopic { get; set; }

    public CourseProgress(string courseName, double currentScore, int completedTopics, string currentTopic)
    {
        CourseName = courseName;
        CurrentScore = currentScore;
        CompletedTopics = completedTopics;
        CurrentTopic = currentTopic;
    }
}

class EducationSystem
{
    private Dictionary<Student, List<CourseProgress>> students =
        new Dictionary<Student, List<CourseProgress>>();

    public void AddOrUpdateStudent(Student student)
    {
        var existingStudent = students.Keys.FirstOrDefault(s => s.Id == student.Id);

        if (existingStudent == null)
        {
            students[student] = new List<CourseProgress>();
        }
        else
        {
            existingStudent.FullName = student.FullName;
            existingStudent.Group = student.Group;
        }
    }

    public void AddOrUpdateCourse(int studentId, CourseProgress progress)
    {
        var student = students.Keys.FirstOrDefault(s => s.Id == studentId);

        if (student == null)
            return;

        var course = students[student]
            .FirstOrDefault(c => c.CourseName == progress.CourseName);

        if (course == null)
        {
            students[student].Add(progress);
        }
        else
        {
            course.CurrentScore = progress.CurrentScore;
            course.CompletedTopics = progress.CompletedTopics;
            course.CurrentTopic = progress.CurrentTopic;
        }
    }

    public void FindByGroup(string group)
    {
        var result = students.Keys.Where(s => s.Group == group);

        foreach (var student in result)
        {
            Console.WriteLine($"{student.FullName} | {student.Group}");
        }
    }

    public void FindByScore(double minScore)
    {
        foreach (var item in students)
        {
            foreach (var course in item.Value.Where(c => c.CurrentScore >= minScore))
            {
                Console.WriteLine($"{item.Key.FullName} | {course.CourseName} | {course.CurrentScore}");
            }
        }
    }

    public void FindByCourseStatus(string courseName)
    {
        foreach (var item in students)
        {
            var course = item.Value.FirstOrDefault(c => c.CourseName == courseName);

            if (course != null)
            {
                Console.WriteLine(
                    $"{item.Key.FullName} | {course.CourseName} | " +
                    $"Topic: {course.CurrentTopic} | Mark: {course.CurrentScore}");
            }
        }
    }

    public void SortByPerformance()
    {
        var sorted = students
            .OrderByDescending(x => x.Value.Average(c => c.CurrentScore));

        foreach (var item in sorted)
        {
            double average = item.Value.Count > 0
                ? item.Value.Average(c => c.CurrentScore)
                : 0;

            Console.WriteLine($"{item.Key.FullName} | Average score: {average:F1}");
        }
    }
}

class Program
{
    static void Main()
    {
        EducationSystem system = new EducationSystem();

        system.AddOrUpdateStudent(
            new Student(1, "Ivan Petrenko", "IPZ-21"));

        system.AddOrUpdateStudent(
            new Student(2, "Maria Koval", "IPZ-22"));

        system.AddOrUpdateCourse(
            1,
            new CourseProgress(
                "C# Programming",
                92,
                12,
                "Collections"));

        system.AddOrUpdateCourse(
            1,
            new CourseProgress(
                "Database Systems",
                85,
                8,
                "SQL JOIN"));

        system.AddOrUpdateCourse(
            2,
            new CourseProgress(
                "C# Programming",
                78,
                9,
                "LINQ"));

        Console.WriteLine("Students of the group IPZ-21:");
        system.FindByGroup("IPZ-21");

        Console.WriteLine("\nStudents with a score of 80:");
        system.FindByScore(80);

        Console.WriteLine("\nCourse progress C# Programming:");
        system.FindByCourseStatus("C# Programming");

        Console.WriteLine("\nSort by success:");
        system.SortByPerformance();

        фміипрвлбвитьегнщ
            нгепкуційвуауеегншшнгенек
            угнешнегшукуацйкценке
            ку5цук67е8шнек6у5ц43у4еункон

            укенгегуеу4к3ційй2у уАПИРРПЦК6Рап
            рекіпфуукпеарнглеш7664кцувсампирвнго8ш76гнриппипптттттттттттттттт
            в2ййвйвв
    }
}
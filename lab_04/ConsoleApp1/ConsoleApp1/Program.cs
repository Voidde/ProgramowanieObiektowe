using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        List<User> users = new List<User>()
        {
         new User { Name = "A", Role = "Student", Age = 15, Marks = new int[] { 3, 5, 2, 1 }, CreatedAt = new DateTime(2022, 1, 3) },
        new User { Name = "X", Role = "Student", Age = 13, Marks = new int[] { 1, 1, 2, 1 }, CreatedAt = new DateTime(2022, 1, 4) },
        new User { Name = "S", Role = "Student", Age = 15, Marks = new int[] { 3, 4, 5, 2 }, CreatedAt = new DateTime(2022, 1, 5) },
        new User { Name = "Z", Role = "Student", Age = 17, Marks = new int[] { 1, 2, 1, 6 }, CreatedAt = new DateTime(2022, 1, 6) },
        new User { Name = "D", Role = "Student", Age = 19, Marks = new int[] { 3, 4, 4, 4 }, CreatedAt = new DateTime(2022, 1, 7) },
        new User { Name = "B", Role = "Student", Age = 13, Marks = new int[] { 3, 3, 3, 3 }, CreatedAt = new DateTime(2022, 1, 8) },
        new User { Name = "HJ", Role = "Student", Age = 15, Marks = new int[] { 3, 6, 2, 1 }, CreatedAt = new DateTime(2022, 1, 9) },
        new User { Name = "AXS", Role = "Student", Age = 18, Marks = new int[] { 3, 1, 2, 1 }, CreatedAt = new DateTime(2022, 1, 10) },
        new User { Name = "ASD", Role = "Student", Age = 19, Marks = new int[] { 3, 4, 2, 1 }, CreatedAt = new DateTime(2022, 1, 11) },
        new User { Name = "HFG", Role = "Student", Age = 11, Marks = new int[] { 3, 3, 2, 1 }, CreatedAt = new DateTime(2022, 1, 12) },
        new User { Name = "GFD", Role = "Student", Age = 13, Marks = new int[] { 3, 1, 2, 1 }, CreatedAt = new DateTime(2022, 1, 13) },
        new User { Name = "AOP", Role = "Student", Age = 14, Marks = new int[] { 3, 5, 2, 2 }, CreatedAt = new DateTime(2022, 1, 14) },
        new User { Name = "AOT", Role = "Student", Age = 20, Marks = new int[] { 3, 5, 2, 5 }, CreatedAt = new DateTime(2022, 1, 15) },
        new User { Name = "POP", Role = "Admin", Age = 29, Marks = null, CreatedAt = new DateTime(2022, 1, 16) },
        new User { Name = "2CX", Role = "Student", Age = 15, Marks = new int[] { 6, 6, 6, 6 }, CreatedAt = new DateTime(2022, 1, 17) },
        new User { Name = "MDA", Role = "Student", Age = 16, Marks = new int[] { 1, 1, 1, 1 }, CreatedAt = new DateTime(2022, 1, 18) },
        new User { Name = "IO", Role = "Student", Age = 18, Marks = new int[] { 3, 5, 4, 1 }, CreatedAt = new DateTime(2022, 1, 19) },
        new User { Name = "AA", Role = "Teacher", Age = 33, Marks = null, CreatedAt = new DateTime(2022, 1, 20) },
        new User { Name = "APC", Role = "Student", Age = 16, Marks = new int[] { 3, 5, 4, 1 }, CreatedAt = new DateTime(2022, 1, 21) },
        new User { Name = "ADC", Role = "Moderator", Age = 23, Marks = null, CreatedAt = new DateTime(2022, 1, 22) },
    };
        Console.WriteLine(users.Count());
        Console.WriteLine((from user in users
                           select user).Count());
        List<string> names_1 = users.Select(user => user.Name).ToList(); // mapowania, projekcja
        List<string> names_2 = (from user in users
                                select user.Name).ToList(); // mapowania, projekcja
        //foreach (string name in names_2)
        //    Console.WriteLine(name);
        //users.Sort((a, b) => { return a.Name.CompareTo(b.Name); });
        List<User> users_1 = users.OrderBy(user => user.Name).ToList();
        List<User> users_2 = (from user in users
                              orderby user.Name
                              select user).ToList();
        foreach (User user in users_2)
            Console.WriteLine(user.Name + " " + user.Age);
    }
    // private static string GetUserName(User user)
    // {
    //     return user.Name;
    // }
}
public class User
{
    public string Name { get; set; }
    public string Role { get; set; } // ADMIN, MODERATOR, TEACHER, STUDENT
    public int Age { get; set; }
    public int[] Marks { get; set; } // zawsze null gdy ADMIN, MODERATOR lub TEACHER
    public DateTime? CreatedAt { get; set; }
    public DateTime? RemovedAt { get; set; }
}
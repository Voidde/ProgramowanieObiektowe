using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User { Name = "A", Role = "Student", Age = 15, Marks = new int[] { 3, 5, 2, 1,5,3 }, CreatedAt = new DateTime(2022, 1, 3) },
                new User { Name = "X", Role = "Student", Age = 13, Marks = new int[] { 1, 1, 2, }, CreatedAt = new DateTime(2022, 6, 4) },
                new User { Name = "S", Role = "Student", Age = 15, Marks = new int[] { 3, 4, 5, 2,4,6 }, CreatedAt = new DateTime(2022, 8, 5) },
                new User { Name = "Z", Role = "Student", Age = 17, Marks = new int[] { 1, 2, 1, }, CreatedAt = new DateTime(2022, 3, 6) },
                new User { Name = "D", Role = "Student", Age = 19, Marks = new int[] { 3, 4, 4, 4 }, CreatedAt = new DateTime(2022, 1, 7) },
                new User { Name = "B", Role = "Student", Age = 13, Marks = new int[] { 3, 3, 3, 3 }, CreatedAt = new DateTime(2022, 5, 8) },
                new User { Name = "HJ", Role = "Student", Age = 15, Marks = new int[] { 3, 6, 2, 1 }, CreatedAt = new DateTime(2022, 1, 9) },
                new User { Name = "AXS", Role = "Student", Age = 18, Marks = new int[] { 3, 1, 2, 1 }, CreatedAt = new DateTime(2022, 11, 10) },
                new User { Name = "ASD", Role = "Student", Age = 19, Marks = new int[] { 3, 4, 2, 1 }, CreatedAt = new DateTime(2022, 12, 11) },
                new User { Name = "HFG", Role = "Student", Age = 11, Marks = new int[] { 3, 3, 2, 5 }, CreatedAt = new DateTime(2022, 10, 12)},
                new User { Name = "GFD", Role = "Student", Age = 13, Marks = new int[] { 3, 1, 2, 2 }, CreatedAt = new DateTime(2022, 1, 13)},
                new User { Name = "AOP", Role = "Student", Age = 14, Marks = new int[] { 3, 5, 2, 2 }, CreatedAt = new DateTime(2022, 1, 14) },
                new User { Name = "AOT", Role = "Student", Age = 20, Marks = new int[] { 3, 5, 3, 5 }, CreatedAt = new DateTime(2022, 2, 15) },
                new User { Name = "POP", Role = "Admin", Age = 29, Marks = null, CreatedAt = new DateTime(2022, 4, 16)},
                new User { Name = "2CX", Role = "Student", Age = 15, Marks = new int[] { 6, 6, 6, 6 }, CreatedAt = new DateTime(2022, 7, 17) },
                new User { Name = "MDA", Role = "Student", Age = 16, Marks = new int[] { 1, 1, 1, 1 }, CreatedAt = new DateTime(2022, 9, 18) },
                new User { Name = "IO", Role = "Student", Age = 18, Marks = new int[] { 3, 5, 4, 1 }, CreatedAt = new DateTime(2022, 11, 19) },
                new User { Name = "AA", Role = "Teacher", Age = 33, Marks = null, CreatedAt = new DateTime(2022, 9, 20) },
                new User { Name = "APC", Role = "Student", Age = 16, Marks = new int[] { 3, 5, 4, 1 }, CreatedAt = new DateTime(2022, 12, 21) },
                new User { Name = "ADC", Role = "Moderator", Age = 23, Marks = null, CreatedAt = new DateTime(2022, 1, 22) },
        };
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 1");

            Console.WriteLine((from user in users select user).Count());
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 2");
            //2
            List<string> names = users.Select(user => user.Name).ToList(); //mapowanie,projekcja
            List<string> names2 = (from user in users select user.Name).ToList();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 3");

            //3
            List<User> users_1 = (from user in users
                                  orderby user.Name
                                  select user).ToList();

            foreach (User user in users_1)
            {
                Console.WriteLine(user.Name);
            }

            //4
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 4");

            List<string> roles = users.Select(user => user.Role).Distinct().ToList();

            foreach (string role in roles)
            {
                Console.WriteLine(role);
            }
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 5");
            //5
            List<User> namesbyrole = (from user in users orderby user.Role select user).ToList();

            foreach (User user in namesbyrole)
            {
                Console.WriteLine(user.Role + " " + user.Name);
            }

            //6
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 6");

            var count = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user.Name);
            Console.WriteLine(count.Count());
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 7");

            List<int[]> oceny = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user.Marks).ToList();

            int suma = 0;
            int iloscocen = 0;


            foreach (int[] ele in oceny)
            {
                foreach (int ocena in ele)
                {
                    iloscocen++;
                    suma += ocena;
                }
            }

            var srednia = (float)(suma / iloscocen);
            Console.WriteLine($"Suma ocen {suma}");
            Console.WriteLine($"Ilosc ocen {iloscocen}");
            Console.WriteLine($"Srednia {srednia}");

            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 8");

            //8
            int max = 0;
            foreach (int[] ele in oceny)
            {
                for (int i = 0; i < ele.Length; i++)
                {
                    int temp = ele[i];

                    if (temp > max)
                    {
                        max = temp;
                    }
                }
            }

            Console.WriteLine(max);

            //9
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 9");

            int min = max;
            foreach (int[] ele in oceny)
            {
                for (int i = 0; i < ele.Length; i++)
                {
                    int temp = ele[i];

                    if (temp < max)
                    {
                        min = temp;
                    }
                }
            }
            Console.WriteLine(min);

            //10
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 10");

           List<User> xs = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user).ToList();

            float sum = 0;
            float licznik = 0;

            float maxsr = 0;
            var name1 = "xsxs";
            foreach (User user in xs)
            {
                foreach(int oc in user.Marks)
                {
                    sum += oc;
                    licznik++;
                }
                float sr = sum / licznik;

                if (sr > maxsr)
                {
                    maxsr = sr;
                    name1 = user.Name;
                }

                licznik = 0;
                sum = 0;
            }
            Console.WriteLine($"{name1}" +" " + maxsr);


            //11
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 11");
            int minOc = 100000;
            int licznikOc1 = 0;

            foreach (User user in xs)
            {
                foreach (int oc in user.Marks)
                {
                    licznikOc1++;
                }

                if (licznikOc1 < minOc)
                {
                    minOc = licznikOc1;
                }

                licznikOc1 = 0;

            }

            List<string> names3 = (from user in users where user.Marks?.Length == minOc select user.Name).ToList();
            foreach (string name in names3)
            {
                Console.WriteLine(name);
            }



            //12
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 12");
            int maxOc = 0;
            int licznikOc2 = 0;
            foreach (User user in xs)
            {
                foreach (int oc in user.Marks)
                {
                    licznikOc2++;
                }

                if (licznikOc2 > maxOc)
                {
                    maxOc = licznikOc2;
                }


                licznikOc2 = 0;


            }

            List<string> names4 = (from user in users where user.Marks?.Length == maxOc select user.Name).ToList();

            foreach (string name in names4)
            {
                Console.WriteLine(name);
            }


            //13
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 13");


            List<User> names5 = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user).ToList();

            int[] srednie = new int[names5.Count];
            int z = 0;
            foreach (User user in names5)
            {

                float sr = (float)user.Marks.Sum() / user.Marks.Length;
                

                Console.WriteLine(user.Name + " " + $"{sr:N2}");
                srednie[z] = (int)sr;

            }


            //14
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 14");

            List<User> names6 = (from user in users where user.Marks != null || user.Marks?.Length > 0 select new User { Name = user.Name, Marks = srednie }).ToList();
            List<User> Mapowanie = new List<User>();
            for (int i = 0; i < srednie.Length; i++)
            {
                Mapowanie = (from user in users where user.Marks != null || user.Marks?.Length > 0 select new User { Name = user.Name, Marks = new int[] { srednie[i] } }).ToList();
            }

            //15
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 15");

            List<User> names11 = (from user in users where user.Marks != null || user.Marks?.Length >  0 orderby ((float)user.Marks.Sum() / user.Marks.Length) descending select user).ToList();
            
            foreach (User user in names11)
            {

                float sr = (float)user.Marks.Sum() / user.Marks.Length;


                Console.WriteLine(user.Name + " " + $"{sr:N2}");

            }


            //16
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 16");
            
            List<User> usersSorted = users.OrderByDescending(user => user.CreatedAt).ToList();
            string[] XSXS = new string[usersSorted.Count];
            foreach (var user in usersSorted)
            {
                var m = user.CreatedAt;
                var y = user.CreatedAt;
          
                string my = m.ToString().Substring(3, 2) + "/" + y.ToString().Substring(6, 4);

                Console.WriteLine(my +" " + user.Name );

            }

 
            //17
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 17");
            
            List<string> usersNotDeleted = (from user in users where user.RemovedAt == null select user.Name).ToList();

            foreach (string nd in usersNotDeleted)
            {
                Console.WriteLine(nd);
            }

            //18
            Console.WriteLine("========================================");
            Console.WriteLine("Zadanie 18");

            var newest = DateTime.Now;
            foreach (var user in usersSorted)
            {
                if (newest < user.CreatedAt)
                {
                    newest = (DateTime)user.CreatedAt;
                    Console.WriteLine(user.Name + " " + user.CreatedAt);
                }
            }
          
        }
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
    }

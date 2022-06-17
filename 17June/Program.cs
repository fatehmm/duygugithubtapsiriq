using System;

namespace _17June
{
    class Program
    {
        static void Main(string[] args)
        {
            Course CodeAcademy = new Course();
            Console.WriteLine("1. Grouplarin siyahisini gostermek");
            Console.WriteLine("2. Secilmis type-daki grouplari goster");
            Console.WriteLine("3. Grouplar uzerinde axtaris etmek");
            Console.WriteLine("4. Group yaratmaq");
            Console.WriteLine("5. Group-da deyisiklik etmek");
            string? answer;
            do
            {
                answer = Console.ReadLine();

            } while (answer !="1" && answer != "2" && answer != "3" && answer !="4");
            switch (answer)
            {
                case "1":
                    foreach (var item in CodeAcademy.groups)
                    {
                        Console.WriteLine($"{item.No} {item.Type}");
                    }
                    break;
                case "2":
                    string? type = Console.ReadLine();
                    if (type != null )
                    {
                        Group[] typedGroups =  CodeAcademy.GetGroupsByType(type);
                        foreach (var item in typedGroups)
                        {
                            Console.WriteLine($"{item.No} {item.Type}");
                        }
                    }
                    break;
                case "3":
                    string? search = Console.ReadLine();
                    if (search != null)
                    {
                        Group[] searchedGroups = CodeAcademy.Search(search);
                        foreach (var item in searchedGroups)
                        {
                            Console.WriteLine($"{item.No} {item.Type}");
                        }
                    }
                    break;
                case "4":
                    Console.Write("Groupun typeini daxil edin....");
                    string? typeGroup = Console.ReadLine();
                    if (typeGroup != null && CodeAcademy.groups.Length+1 < CodeAcademy.GroupLimit)
                    {
                        Group groupAdded = new Group()
                        {
                            Type = typeGroup
                        };
                        CodeAcademy.AddGroup(ref groupAdded);
                        Console.WriteLine("Add olundu");
                    }
                    else
                    {
                        goto case "4";
                    }
                    break;
                case "5":
                    Console.Write("Deyisiklik etmek istediyiniz groupun no daxil edin....");
                    string? answerGroup = Console.ReadLine();
                    Console.Write("Deyisiklik etmek istediyiniz grupun yeni student limitini daxil edin....");
                    string? answerLimit = Console.ReadLine();
                    bool check = int.TryParse(answerLimit, out int answerLimitInt);
                    Console.Write("Deyisiklik etmek istediyiniz groupun yeni adini daxil edin....");
                    string? answerNewGroup = Console.ReadLine();

                    if (answerGroup != null && check)
                    {
                        CodeAcademy.UpdateGroup(answerGroup, answerNewGroup, answerLimitInt);
                    }
                    else
                    {
                        Console.WriteLine("Xeta bas verdi yeniden yoxlayin");
                        goto case "5";
                    }
                    break;

                default:
                    break;
            }



        }
    }
}


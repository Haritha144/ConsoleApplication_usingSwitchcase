class Program
{
    public string name;
    private int mark1;
    private int mark2;
    private int mark3;

    public Program(string name,int mark1,int mark2,int mark3)
    {
        Name = name;
        Mark1 = mark1;
        Mark2 = mark2;
        Mark3 = mark3;
    }
    public string Name
    {
        get { return name; }
        set { 
        if(!String.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }

    }
    public int Mark1
    {
        get { return mark1; }
        set
        {
            if (mark1 >= 0 && mark1 <= 100)
            {
                mark1 = value;

            }
            else
            {
                Console.WriteLine("Invalid Mark");
            }
        }

    }
        public int Mark2
    {
        get { return mark2; }
        set
        {
            if (mark2 >= 0 && mark2 <= 100)
            {
                mark2 = value;

            }
            else
            {
                Console.WriteLine("Invalid Mark");
            }

        }
    }
    public int Mark3
    {
        get { return mark3; }
        set
        {
            if (mark3 >= 0 && mark3 <= 100)
            {
                mark3 = value;

            }
            else
            {
                Console.WriteLine("Invalid Mark");
            }

        }
    }

    static void Main(string[] args)
    {
          
        while(true)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Student Mark Calculator");
            Console.WriteLine("Enter your choice");
            Console.WriteLine(" 1 Total");
            Console.WriteLine("2 Average");
            Console.WriteLine("3 Grade");
            Console.WriteLine("4 Exit");
            Console.WriteLine();
            int Choice = Convert.ToInt32(Console.ReadLine());
            if(Choice==4)
            {
                Console.WriteLine("Exited successfully");
                break;
            }
            else
            {
                Console.WriteLine("Enter Student name : ");
                string sname = Console.ReadLine();
                Console.WriteLine("Enter Student mark1 : ");
                int m1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student mark2 : ");
                int m2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student mark3 : ");
                int m3 = Convert.ToInt32(Console.ReadLine());
                Program s = new Program(sname,m1,m2,m3);
               
                switch(Choice)
                {
                    case 1:
                        int total = s.Mark1 + s.Mark2 + s.Mark3;
                        Console.WriteLine($"Total is {total}");
                        break;
                    case 2:
                        double avg=(s.Mark1+s.Mark2+s.Mark3) / 3;
                        int average = Convert.ToInt32(avg);
                        Console.WriteLine($"Average is {average}");
                        break;
                    case 3:
                        int total1 = s.Mark1 + s.Mark2 + s.Mark3;
                        int average1 = Convert.ToInt32(total1 / 3);
                        Console.WriteLine(average1);
                        String grade;
                        if(average1 >= 90)
                        {
                            grade = "A";
                        }
                        else if (average1 >= 75)
                        {
                            grade = "B";
                        }
                        else if (average1 >= 60)
                        {
                            grade = "C";
                        }
                        else if (average1 >= 45)
                        {
                            grade = "D";
                        }
                        else
                        {
                            grade = "E";
                        }
                        Console.WriteLine($"Grade is {grade}");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }

            }
        }




    }
           
               
    
}
#region switch calc
//{

//}while (true)

//Console.WriteLine("1 Addition ");
//Console.WriteLine("2 Subtraction ");
//Console.WriteLine("3 Multiplication ");
//Console.WriteLine("4 Division");
//Console.WriteLine("5 Exit ");
//Console.WriteLine("Enter your Choice : ");


//int choice = Convert.ToInt32(Console.ReadLine());
//if (choice == 5)
//{
//    break;
//}
//else
//{
//    Console.WriteLine("Enter the first number");
//    int a = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter the second number");
//    int b = Convert.ToInt32(Console.ReadLine());
//    switch(choice)
//    {
//        case 1:
//            Console.WriteLine($"Addition of a&b is {a+b}");
//            break;
//        case 2:
//            Console.WriteLine($"Subtraction of A&b is {a-b}");
//            break;
//        case 3:
//            Console.WriteLine($"Multiplication of a&b is {a * b}");
//            break;
//        case 4:
//            if (b != 0)
//            {
//                Console.WriteLine($"Division of a&b is {a / b}");
//            }
//            else
//            {
//                Console.WriteLine($"cannot be divided by zero");
//            }
//            break;
//        default:
//            Console.WriteLine("Invalid choice");
//            break;
//    }
#endregion


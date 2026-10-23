using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        Queue<string> jobs = new Queue<string>();
        Stack<string> stack = new Stack<string>();
        int finished = 0;
        bool choice = 0;

        do
        {
            Console.WriteLine("===============================");
            Console.WriteLine("STUDENT SERVICE CUEUE SYSTEM");
            Console.WriteLine("===============================");


            Console.WriteLine("[1] - Add Student");
            Console.WriteLine("[2] - Show Waiting Students");
            Console.WriteLine("[3] - Serve Next Student");
            Console.WriteLine("[4] - Show Last Served Student");
            Console.WriteLine("[5] - Exit");

            Console.Write("Enter Choice: ");

            int.TryParse(Console.ReadLine(), out finished);

            switch (choice)
            {
                case 1:
                    Console.Write("Add Student: ");
                    string student = Console.ReadLine();

                    student.Enqueue(student);
                    Console.WriteLine("new student has been added!");
                    break;

                case 2:
                    if (student.Count > 0)
                    {
                        Console.WriteLine("Student Waiting: ");
                        foreach (string s in student)
                            Console.WriteLine(s);
                    }
                    else
                    {

                        Console.WriteLine(" no student waiting");
                    }
                    break;

                case 3:
                    if (student.count = 0)
                    {
                        students.Dequeue();
                        Console.WriteLine("serving student: ");
                        student.push(student);

                        Console.WriteLine("Student Successfully Served: ");
                    }
                    break;
                case 4:
                    if (student.Count > 0)
                        Console.WriteLine("Last Serves Student: " + student.peek());
                    else
                        Console.WriteLine("No Student Have Been Served. ");
                    {
                        break;
                    }
                case 5:
                    Console.WriteLine("Program ended.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
                }
            }

        }


    }
}



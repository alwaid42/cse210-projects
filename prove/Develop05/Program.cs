using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        bool loopBreak = true;
        List<Goal> myGoals = new List<Goal>();
        while (loopBreak)
        {
            
            //Check for score
            Console.WriteLine("\nYou have 0 points\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goals");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    bool lpbk = true;
                    while (lpbk)
                    {
                        Console.WriteLine("The types of Goals are:");
                        Console.WriteLine(" 1. Simple Goal");
                        Console.WriteLine(" 2. Eternal Goal");
                        Console.WriteLine(" 3. Checklist Goal");
                        Console.Write("Which type of goal would you like to create? ");
                        string goalType = Console.ReadLine();

                        switch(goalType)
                        {
                            case "1":
                                Console.Write("What is the name of your goal? ");
                                string n1 = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string d1 = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                int p1 = int.Parse(Console.ReadLine());

                                Simple newGoal1 = new Simple(n1, d1, p1);

                                myGoals.Add(newGoal1);
                                lpbk = false;

                                break;
                            
                            case "2":
                                Console.Write("What is the name of your goal? ");
                                string n2= Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string d2 = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                int p2 = int.Parse(Console.ReadLine());

                                Eternal newGoal2 = new Eternal(n2, d2, p2);

                                myGoals.Add(newGoal2);
                                lpbk = false;
                                
                                break;

                            case "3":
                                Console.Write("What is the name of your goal? ");
                                string n3= Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string d3 = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                int p3 = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                int times = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times? ");
                                int bonus = int.Parse(Console.ReadLine());

                                Checklist newGoal3 = new Checklist(n3, d3, p3, times, bonus);

                                myGoals.Add(newGoal3);
                                lpbk = false;

                                break;

                            default:
                                Console.WriteLine("Please enter a valid choice.");
                                break;
                        }
                    }

                    break;

                case "2":
                    int count = 1;
                    foreach (Goal gl in myGoals)
                        {
                            Console.Write($"{count}. ");
                            gl.ReturnGoal();
                            count++;
                        }
                    break;


//Is currentrly overriding the file. Possible improvement. just add new lines.               
                case "3":
                    Console.Write("What is the filename? ");
                    string file = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(file))
                    {
                        // You can add text to the file with the WriteLine method
                        // You can use the $ and include variables just like with Console.WriteLine
                        foreach (Goal gl in myGoals)
                        {
                            outputFile.WriteLine(gl.WriteFile());
                        }
                    }
                    Console.WriteLine("Goals saved in the file");
                    break;
                
                case "4":
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        char[] delimiterChars = {'|'};
                        
                    }
                    break;

                case "5":
                    break;

                case "6":
                    loopBreak = false;
                    break;

                default:
                    Console.WriteLine("Please enter a valid choice.");
                    break;
            }
        }
        
    }
}
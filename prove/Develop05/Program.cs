using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        bool loopBreak = true;
        List<Goal> myGoals = new List<Goal>();
        int points = 0;
        while (loopBreak)
        {
            //Check for score
            Console.WriteLine($"\nYou have {points} points\n");

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
                        Console.WriteLine(" 4. Negative Goal (You lose points when you do it)");
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

                            case "4":
                                Console.Write("What is the name of your goal? ");
                                string n4= Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string d4 = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                int p4 = int.Parse(Console.ReadLine());

                                Negative newGoal4 = new Negative(n4, d4, p4);

                                myGoals.Add(newGoal4);
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

           
                case "3":
                    Console.Write("What is the filename? ");
                    string file = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(file))
                    {
                        outputFile.WriteLine(points);
                        foreach (Goal gl in myGoals)
                        {
                            outputFile.WriteLine(gl.WriteFile());
                        }
                    }

                    //This code I used so that my document wasnt overwritten. But I decided that I want my file to be overwritten.
                    /*
                    if(!File.Exists(file))
                    {
                        using (StreamWriter outputFile = new StreamWriter(file))
                        {
                            outputFile.WriteLine(points);
                            foreach (Goal gl in myGoals)
                            {
                                outputFile.WriteLine(gl.WriteFile());
                            }
                        }
                    }

                    else 
                    {
                        using (StreamWriter outputFile = File.AppendText(file))
                        {
                            outputFile.WriteLine(points);
                            foreach (Goal gl in myGoals)
                            {
                                outputFile.WriteLine(gl.WriteFile());
                            }
                        }
                    }
                    */


                    Console.WriteLine("Goals saved in the file");
                    break;
                
                case "4":
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        char[] delimiterChars = {'|'};
                        string[] parts = line.Split(delimiterChars);
                        
                        string f0 = "Simple|Eternal|Checklist|Negative";
                        string[] f1 = f0.Split(delimiterChars); 
                        
                        if(String.Equals("Simple", parts[0]))
                        {
                            int newPoints = int.Parse(parts[3]);
                            bool completedS = bool.Parse(parts[4]);
                            Simple newGoalS = new Simple(parts[1], parts[2], newPoints, completedS);
                            myGoals.Add(newGoalS);
                        }
                        else if(String.Equals("Eternal", parts[0]))
                        {
                            int newPoints = int.Parse(parts[3]);
                            Eternal newGoalE = new Eternal(parts[1], parts[2], newPoints);
                            myGoals.Add(newGoalE);
                        }
                        else if(String.Equals("Checklist", parts[0]))
                        {
                            int newPoints = int.Parse(parts[3]);
                            int times = int.Parse(parts[4]);
                            int bonus = int.Parse(parts[5]);
                            int accomplished = int.Parse(parts[6]);
                            Checklist newGoalC = new Checklist(parts[1], parts[2], newPoints, times, bonus, accomplished);
                            myGoals.Add(newGoalC);
                        }
                        else if(String.Equals("Negative", parts[0]))
                        {
                            int newPoints = int.Parse(parts[3]);
                            Negative newGoalN = new Negative(parts[1], parts[2], newPoints);
                            myGoals.Add(newGoalN);
                        }
                        else
                        {
                            points = int.Parse(parts[0]);
                        }
                    }
                    break;

                case "5":
                    int count2 = 1;
                    int count3 = 0;
                    Console.WriteLine("The goals are:");
                    
                    Dictionary<int, int> myDict = new Dictionary<int, int> ();

                    foreach (Goal gl in myGoals)
                    {
                        if (gl.IsComplete() == false)
                        {
                            Console.Write($"{count2}. ");
                            gl.ReturnGoalName();
                            myDict.Add(count2, count3);
                            count2++;
                        }
                        count3++;
                    }

                    Console.Write("Which goal did you accomplish? ");
                    int input = int.Parse(Console.ReadLine());
                    points += myGoals[myDict[input]].RecordEvent();
                    Console.WriteLine($"You now have {points} points");
                    
                    
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
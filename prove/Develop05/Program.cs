using System;
class Program
{
    static void Main(string[] args)
    {
        GoalCompile GoalCompile = new GoalCompile();
        int userMainMenuSelection = 0;

        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest app");
        Console.WriteLine();

        while (userMainMenuSelection != 6)
        {
            Menu menu = new Menu();
            GoalCompile.DisplayPoints(GoalCompile.getTotalPoints());
            Console.WriteLine();
            menu.DisplayMainMenu();
            userMainMenuSelection = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMainMenuSelection)
            {
                case 1:
                    menu.DisplayNewGoalMenu();
                    int userNewGoalSelection = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Goal goal = null;
                    if (userNewGoalSelection == 1)
                    {
                        goal = new SimpleGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }
                    else if (userNewGoalSelection == 2)
                    {
                        goal = new EternalGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }
                    else
                    {
                        goal = new CheckListGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }

                    if (goal != null)
                    {
                        GoalCompile.addGoal(goal);
                    }
                    break;

                case 2:
                    GoalCompile.DisplayGoals();
                    break;

                case 3:
                    GoalCompile.SaveGoals();
                    break;

                case 4:
                    GoalCompile.LoadGoals();
                    break;

                case 5:
                    GoalCompile.DisplayGoalRecordEvent();
                    break;

                case 6:
                    
                    Console.WriteLine("Thank you! Goodbye. ");
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    break;

            }
        }
    }
}
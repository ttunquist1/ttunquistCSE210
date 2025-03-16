using System;
class GoalCompile
{
    private List<Goal> _GoalCompile = new List<Goal>();
    private int _totalPoints;
    private string _fileName;

    public void addGoal(Goal _goal)
    {
        _GoalCompile.Add(_goal);
    }

    public int getTotalPoints()
    {
        return _totalPoints;
    }

    public void DisplayPoints(int totalPoints)
    {
        
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public void DisplayGoals()
    {
        if (_GoalCompile.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
            return;
        }
        Console.WriteLine("Your goals:");
        foreach (Goal goal in _GoalCompile)
        {
            Console.WriteLine($"{_GoalCompile.IndexOf(goal) + 1}. {goal.ToString()}");
        }
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        if (_GoalCompile.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.");
            Console.WriteLine();
            return;
        }
    
        Console.WriteLine("Please enter the filename you wish to save: ");
        _fileName = Console.ReadLine();
        string fileToSave = _fileName;
        List<string> saveGoals = new List<string>();
        //save points first
        saveGoals.Add(_totalPoints.ToString());
        foreach (Goal goal in _GoalCompile)
        {
            saveGoals.Add(goal.ToCSVRecord());
        }
        SaveLoadCSV.SaveToCSV(saveGoals, fileToSave);
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        List<string> fileGoals;
        Console.WriteLine("Please enter the filename you wish to load: ");
        _fileName = Console.ReadLine();
        fileGoals = SaveLoadCSV.LoadFromCSV(_fileName);
        _totalPoints = int.Parse(fileGoals[0]) + _totalPoints;

        Goal goal = null;
        foreach (string fileGoal in fileGoals)
        {
            
            string[] goalParts = fileGoal.Split('|');
            string goalType = goalParts[0];
            if (goalType == "Simple")
            {
                goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
            }
            else if (goalType == "Eternal")
            {
                goal = new EternalGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), bool.Parse(goalParts[5]));
            }
            else if (goalType == "CheckList")
            {
                goal = new CheckListGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), int.Parse(goalParts[5]), int.Parse(goalParts[6]), bool.Parse(goalParts[7]));
            }

            if (goal != null && _GoalCompile.Contains(goal) == false)
            {
                _GoalCompile.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded.");
    }

    public void DisplayGoalRecordEvent()
    {
        Console.WriteLine("Your Goals are:");
        foreach (Goal goal in _GoalCompile)
        {
            Console.WriteLine(string.Format($"{_GoalCompile.IndexOf(goal) + 1}. [{((goal.GetGoalStatus() == false) ? " " : "x")}] {goal.GetGoalName()}"));
        }
        Console.Write("Which goal did you complete? ");
        int recordEvent = int.Parse(Console.ReadLine()) - 1;
        Console.Clear();
        bool status = _GoalCompile[recordEvent].GetGoalStatus();
        if (status == false)
        {
            _GoalCompile[recordEvent].RecordEvent();
            _totalPoints += _GoalCompile[recordEvent].GetGoalPoints();
            Console.WriteLine(string.Format($"You now have {_totalPoints.ToString()} points!"));
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("You have already completed that goal!");
            Console.WriteLine();
        }
    }
}
/*
Provide for a checklist goal that must be accomplished a certain number of times to be complete. 
Each time the user records this goal they gain some value, but when they achieve the desired amount, 
they get an extra bonus.*/
public class CheckListGoal : Goal
{
    // Attributes
    private string _typeOfGoal;
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private bool _isComplete = false;

    // 1 method
    public CheckListGoal(string name, string description, int points, string goal, int target, int bonus) : base(name, description, points)
    {
        _typeOfGoal = goal;
        _target = target;
        _bonus = bonus;
    }

    // 2 method
    public override void RecordEvent()
    {
        if (IsComplete() && GetAmountCompleted() == _target)
        {
            AddSetPointToCurrentPoint();
            SetCheckMark();
        }
        else
        {
            AddSetPointToCurrentPoint();
            SetAmountCompleted();
            _isComplete = false;
        }
    }

    // 3 method
    public override bool IsComplete()
    /*
    IsComplete - This method should return true if the goal is completed. 
    The way you determine if a goal is complete is different for each type of goal.
    */
    {
        return _isComplete;
    }

    // 4 method
    public override string GetDetailsString()
    /*
    GetDetailsString - This method should return the details of a goal that could be shown in a list. 
    It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, 
    it should be overridden to shown the number of times the goal has been accomplished so far.
    */
    {
        return $"{GetCheckMark()} {_shortName} * {_description} 👉 Progress status {GetAmountCompleted()} * {_target}";
    }

    // 5 method
    public override string GetStringRepresentation()
    /*
    GetStringRepresentation - This method should provide all of the details of a goal in a way that is 
    easy to save to a file, and then load later.
    */
    {
        return $"\n{_typeOfGoal}:\n⏺️  Goal name: {_shortName}\n⏺️  Goal description: {_description}\n⏺️  Goal value in points: {_points}\n⏺️  Number of times needed to complete the goal: {_bonus}\n⏺️  Bonus value in points: {_target}\n⏺️  Amount Completed: {GetAmountCompleted()}\n⏺️  Is Complete?: {IsComplete()}";
    }

    // 6 method
    public void SetAmountCompleted()
    {
        _amountCompleted++;
    }

    // 7 method
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    // 8 method
    public override void SetIsCompleteToTrue()
    {
        _isComplete = true;
    }

    // 9 method
    public void AddSaveAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

}
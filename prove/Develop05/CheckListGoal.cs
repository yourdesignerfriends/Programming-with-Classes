/*
Provide for a checklist goal that must be accomplished a certain number of times to be complete. 
Each time the user records this goal they gain some value, but when they achieve the desired amount, 
they get an extra bonus.*/
public class CheckListGoal : Goal
{
    // Attributes
    private string _typeOfGoal;
    private int _amountCompleted = 0;
    private int _targetQuantity;
    private int _bonus;
    private bool _isComplete = false;

    public CheckListGoal(string name, string description, int points, string goal, int targetQuantity, int bonus) : base(name, description, points)
    {
        _typeOfGoal = goal;
        _targetQuantity = targetQuantity;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (IsComplete() && GetAmountCompleted() == _targetQuantity)
        {
            AddPoint();
            SetCheckMark();
        }
        else
        {
            AddPoint();
            SetAmountCompleted();
            _isComplete = false;
        }
    }

    public override bool IsComplete()
    /*
    IsComplete - This method should return true if the goal is completed. 
    The way you determine if a goal is complete is different for each type of goal.
    */
    {
        return _isComplete;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    
    public void AddAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
    public void SetAmountCompleted()
    {
        // x = x + 1 (value of x before it was incremented)
        _amountCompleted++;
    }

    public override string GetDetailsString()
    /*
    GetDetailsString - This method should return the details of a goal that could be shown in a list. 
    It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, 
    it should be overridden to shown the number of times the goal has been accomplished so far.
    */
    {
        return $"{GetCheckMark()} {_shortName} ({_description}) -- Currently complete {GetAmountCompleted()}/{_targetQuantity}";
    }

    public override string GetStringRepresentation()
    /*
    GetStringRepresentation - This method should provide all of the details of a goal in a way that is 
    easy to save to a file, and then load later.
    */
    {
        return $"{_typeOfGoal}: {_shortName} , {_description} , {_points} , {_bonus} , {_targetQuantity} , {GetAmountCompleted()} , {IsComplete()}";
    }

    public override void SetIsCompleteToTrue()
    {
        _isComplete = true;
    }
}
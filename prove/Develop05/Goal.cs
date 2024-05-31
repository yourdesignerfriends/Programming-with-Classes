/*
The "Goal" base class defines common responsibilities, behaviors, and attributes. 
As well as having derived classes that override any necessary behavior 
of the base class and add any additional unique responsibilities they have.
*/
public  abstract class Goal
{
    // Attributes
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected int _currentPoint = 0;
    protected string _checkBox = "[ ]";

    // 1 method
    public Goal (string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // 2 method
    public abstract void RecordEvent();

    // 3 method
    /*
    IsComplete - This method should return true if the goal is completed. 
    The way you determine if a goal is complete is different for each type of goal.
    */
    public abstract bool IsComplete();
    

    // 4 method
    public virtual void SetIsCompleteToTrue()
    {
        
    }

    // 5 method
    public virtual string GetDetailsString()
    /*
    GetDetailsString - This method should return the details of a goal that could be shown in a list. 
    It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, 
    it should be overridden to shown the number of times the goal has been accomplished so far.
    */
    {
        return $"{GetCheckMark()} {_shortName} - {_description}";
    }

    // 6 method
    public abstract string GetStringRepresentation();
    /*
    GetStringRepresentation - This method should provide all of the details of a goal in a way that is 
    easy to save to a file, and then load later.
    */

    // 7 method
    public int GetCurrentPoint()
    {
        return _currentPoint;
    }

    // 8 method
    public string GetGoalName()
    {
        return _shortName;
    }

    // 9 method
    public int GetSetPoint()
    {
        return _points;
    }

    // 10 method
    public void AddSetPointToCurrentPoint()
    {
        _currentPoint += _points;
    }

    // 11 method
    public void SetCheckMark()
    {
        string newCheckBox = _checkBox.Replace(_checkBox, "[X]");
        _checkBox = newCheckBox;
    }

    // 12 method
    public string GetCheckMark()
    {
        return _checkBox;
    }
}
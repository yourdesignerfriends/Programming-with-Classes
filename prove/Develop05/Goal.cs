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

    public Goal (string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
    // This method should return true if the goal is completed.
    // The way you determine if a goal is complete is different for each type of goal.

    public int GetCurrentPoint()
    {
        return _currentPoint;
    }
    public void AddPoint()
    // Calculation to add the points obtained to the total.
    {
        _currentPoint += _points;
    }

    //******************************************** Getters and Setters **************************************************************
    // Get Check Mark
    public string GetCheckMark()
    {
        return _checkBox;
    }
    // Set Check Mark
    public void SetCheckMark()
    {
        string newCheckBox = _checkBox.Replace(_checkBox, "[X]");
        _checkBox = newCheckBox;
    }

    public abstract string GetStringRepresentation();
    // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.

    public virtual string GetDetailsString()
    /*
    GetDetailsString - This method should return the details of a goal that could be shown in a list. 
    It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, 
    it should be overridden to shown the number of times the goal has been accomplished so far.
    */
    {
        return $"{GetCheckMark()} {_shortName} ({_description})";
    }

    public string GetGoalName()
    {
        return _shortName;
    }

    public int GetSetPoint()
    {
        return _points;
    }
    
    public virtual void SetIsCompleteToTrue()
    {    

    }
}
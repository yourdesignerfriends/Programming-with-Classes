/*
Provide for simple goals that can be marked complete and the user gains some value.
*/
public class SimpleGoal : Goal
{
    // Attributes
    private string _typeOfGoal;
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _typeOfGoal = goal;
    }

    public override bool IsComplete()
    /*
    IsComplete - This method should return true if the goal is completed. 
    The way you determine if a goal is complete is different for each type of goal.
    */
    {
        return _isComplete;
    }

    public override void SetIsCompleteToTrue()
    {
        _isComplete = true;
    }

    public override void RecordEvent()
    /*
    This method should do whatever is necessary for each specific kind of goal:
    - Marking a simple goal complete 
    - It should return the point value associated with recording 
    */
    {
        if (IsComplete())
        {
            AddPoint();
            SetCheckMark();
        }
    }

    public override string GetStringRepresentation()
    /*
    GetStringRepresentation - This method should provide all of the details of a goal in a way that is 
    easy to save to a file, and then load later.
    */
    {
        return $"{_typeOfGoal}: {_shortName} , {_description} , {_points} , {IsComplete()}";
    }
}
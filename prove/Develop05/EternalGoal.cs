/*
Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
*/
public class EternalGoal : Goal
{
    // Attributes
    private string _typeOfGoal;


    public EternalGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _typeOfGoal = goal;
    }

    public override bool IsComplete()
    /*
    IsComplete - This method should return true if the goal is completed. 
    The way you determine if a goal is complete is different for each type of goal.
    */
    {
        return false;
    }

    public override void RecordEvent()
    /*
    This method should do whatever is necessary for each specific kind of goal:
    - It should return the point value associated with recording 
    - Does not receive a check mark since the goal is eternal
    */
    {
        if (IsComplete())
        {
            AddPoint();
        }
    }

    public override string GetStringRepresentation()
    /*
    GetStringRepresentation - This method should provide all of the details of a goal in a way that is 
    easy to save to a file, and then load later.
    */
    {
        return $"{_typeOfGoal}: {_shortName} , {_description} , {_points}";
    }


}
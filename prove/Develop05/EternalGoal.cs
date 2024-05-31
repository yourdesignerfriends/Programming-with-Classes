/*
Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
*/
public class EternalGoal : Goal
{
    // Attributes
    private string _typeOfGoal;

    // 1 method
    public EternalGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _typeOfGoal = goal;
    }

    // 2 method
    public override void RecordEvent()
    {
        if (IsComplete())
        {
            AddSetPointToCurrentPoint();
        }
    }

    // 3 method
    public override bool IsComplete()
    /*
    IsComplete - This method should return true if the goal is completed. 
    The way you determine if a goal is complete is different for each type of goal.
    */
    {
         return false;
    }

    // 4 method
    public override string GetStringRepresentation()
    /*
    GetStringRepresentation - This method should provide all of the details of a goal in a way that is 
    easy to save to a file, and then load later.
    */
    {
        return $"\n{_typeOfGoal}:\n⏺️  Goal name: {_shortName}\n⏺️  Goal description: {_description}\n⏺️  Goal value in points: {_points}\n⏺️  Is Complete?: {IsComplete()}";
    }


}
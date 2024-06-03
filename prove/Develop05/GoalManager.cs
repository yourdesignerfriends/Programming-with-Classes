/*
Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
DisplayPlayerInfo - Displays the players current score.
ListGoalNames - Lists the names of each of the goals.
ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
SaveGoals - Saves the list of goals to a file.
LoadGoals - Loads the list of goals from a file.
*/
public class GoalManager
{
    // Attributes
    private List<Goal> _goals = [];
    private int _score;
    private int _count = 0;
    private string _folderPath = "GoalFolder/";

    public void Start()
    {
        // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        Console.ForegroundColor = ConsoleColor.Yellow;
        DisplayPlayerInfo();
        Console.WriteLine("\nMenu Options:");
        string menuOptions = "\n   A. Create New Goal\n   B. List Goals\n   C. Save Goals\n   D. Load Goals\n   E. Record Event\n   F. Quit";
        
        bool startAgain = true;
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            DisplayPlayerInfo();
            Console.WriteLine(menuOptions);
            Console.Write("\nSelect a choice from the menu: ");
            string option = Console.ReadLine().ToUpper();

            if (option == "A")
           {
                CreateGoal();
           }
           else if (option == "B")
           {
                Console.WriteLine("");
                ListGoals();
           }
           else if (option == "C")
           {
                SaveGoal();
           }
           else if (option == "D")
           {
                LoadGoals();
           }
           else if (option == "E")
           {
                RecordEvent();
           }
           else if (option == "F")
           {
                DisplayFinalMessage();
                break;
           }

        } while (startAgain);
    }

    private  void DisplayPlayerInfo()
    {
        // DisplayPlayerInfo - Displays the players current score.
        Console.WriteLine($"\nYou have {_score} points.");
    }

    private  void DisplayFinalMessage()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nHave a day full of many successes, see you soon.\n\n\n");
        Console.ForegroundColor = ConsoleColor.White;
        AsciiArtFinalMessage();

    }

    //****************************************** CreateGoal **************************************************************
    private void CreateGoal()
    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        string[] goalTypes = {"Simple Goal", "Eternal Goals", "Checklist Goals"};
        AsciiArtTypesOfGoals();
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine($"\n   1. {goalTypes[0]}: (Are those that can be accomplished in a week or two)\n\n   2. {goalTypes[1]}: (The most important goals in life that will give you joy as you fulfill your mission on this earth.)\n\n   3. {goalTypes[2]}: (goal that must be accomplished a certain number of times to be complete.)\n");
        Console.Write("Which type of goal would you like to create? ");
        int typeOfGoal = int.Parse(Console.ReadLine()) - 1;

        if (typeOfGoal == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            AsciiArtSimpleGoal();
            SimpleGoal simpleGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal]);
            // Add goal to the list.
            _goals.Add(simpleGoal);
            CongratulationsCreateNewGoal();
        }
        else if (typeOfGoal == 1)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            AsciiArtEternalGoal();                                                                   
            EternalGoal eternalGoal = new (name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal]);
            // Add goal to the list.
            _goals.Add(eternalGoal);
            CongratulationsCreateNewGoal();
        }
        else if (typeOfGoal == 2)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            AsciiArtchecklistGoal();
            CheckListGoal checkListGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal], target: SetCheckListCount(), bonus: SetBonusPoint());
            // Add goal to the list.
            _goals.Add(checkListGoal);
            CongratulationsCreateNewGoal();
        }
        else
        {
            Console.WriteLine("Follow the program instructions 🫡, remember there are only three types of Goals, you must select a correct option.");
        }
    }


    private string SetGoalName()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nNow let's give this Goal a name 🥰, write the name you would like to give it\n - ");
        string _goalname = Console.ReadLine();
        return _goalname;
    }
    private string SetGoalDescription()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nWrite a short description of your goal\n - ");
        string _goalDescription = Console.ReadLine();
        return _goalDescription;
    }
    private int SetGoalPoint()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nEnter the amount of points you want to earn by completing this goal\n - ");
        int _goalPoint = int.Parse(Console.ReadLine());
        return _goalPoint;
    }
    private void CongratulationsCreateNewGoal()
    {
        Console.WriteLine("\nCongratulations your goal has been successfully created.");
        Console.WriteLine("\n------------------------------------------------------------------------------------------------");
    }
        private void ListGoalNames()
    {

    //****************************************** B. List Goals ***************************************************************
    // ListGoalNames - Lists the names of each of the goals.
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetGoalName()}");
            }
            _count = 0;
        }
        else 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nI don't have any goals to show you.\n\nYou could... create new goals 🤠!");
            Console.WriteLine("\nPress enter to start over 🙂\n");
            Console.ReadKey();

            Console.Clear();
            GoalManager goalManager = new();
            goalManager.Start();
        }
    }
        private void ListGoalDetails()
    //ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetDetailsString()}");
            }
            _count = 0;
        }
        else 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I don't have any goals to show you.\n\nYou could... create new goals 🤠!");
            Console.WriteLine("\nPress enter to start over 🙂\n");
            Console.ReadKey();

            Console.Clear();
            GoalManager goalManager = new();
            goalManager.Start();
        }
    }

    //****************************************** A. Create New Goal **************************************************************

    private  void AsciiArtTypesOfGoals()
    {
        Console.WriteLine("\n\n████████ ██    ██ ██████  ███████ ███████      ██████  ███████      ██████   ██████   █████  ██      ███████");
        Console.WriteLine("   ██     ██  ██  ██   ██ ██      ██          ██    ██ ██          ██       ██    ██ ██   ██ ██      ██");      
        Console.WriteLine("   ██      ████   ██████  █████   ███████     ██    ██ █████       ██   ███ ██    ██ ███████ ██      ███████"); 
        Console.WriteLine("   ██       ██    ██      ██           ██     ██    ██ ██          ██    ██ ██    ██ ██   ██ ██           ██"); 
        Console.WriteLine("   ██       ██    ██      ███████ ███████      ██████  ██           ██████   ██████  ██   ██ ███████ ███████\n");
    }
    private  void AsciiArtSimpleGoal()
    {
        Console.WriteLine("\n\n███████ ██ ███    ███ ██████  ██      ███████      ██████   ██████   █████  ██");      
        Console.WriteLine("██      ██ ████  ████ ██   ██ ██      ██          ██       ██    ██ ██   ██ ██");      
        Console.WriteLine("███████ ██ ██ ████ ██ ██████  ██      █████       ██   ███ ██    ██ ███████ ██");      
        Console.WriteLine("     ██ ██ ██  ██  ██ ██      ██      ██          ██    ██ ██    ██ ██   ██ ██");      
        Console.WriteLine("███████ ██ ██      ██ ██      ███████ ███████      ██████   ██████  ██   ██ ███████\n"); 
    }
    private  void AsciiArtEternalGoal()
    {
        Console.WriteLine("\n\n███████ ████████ ███████ ██████  ███    ██  █████  ██           ██████   ██████   █████  ██");      
        Console.WriteLine("██         ██    ██      ██   ██ ████   ██ ██   ██ ██          ██       ██    ██ ██   ██ ██");      
        Console.WriteLine("█████      ██    █████   ██████  ██ ██  ██ ███████ ██          ██   ███ ██    ██ ███████ ██");      
        Console.WriteLine("██         ██    ██      ██   ██ ██  ██ ██ ██   ██ ██          ██    ██ ██    ██ ██   ██ ██");      
        Console.WriteLine("███████    ██    ███████ ██   ██ ██   ████ ██   ██ ███████      ██████   ██████  ██   ██ ███████\n"); 
    }
    private  void AsciiArtchecklistGoal()
    {
        Console.WriteLine("\n\n ██████ ██   ██ ███████  ██████ ██   ██     ██      ██ ███████ ████████      ██████   ██████   █████  ██");      
        Console.WriteLine("██      ██   ██ ██      ██      ██  ██      ██      ██ ██         ██        ██       ██    ██ ██   ██ ██");      
        Console.WriteLine("██      ███████ █████   ██      █████       ██      ██ ███████    ██        ██   ███ ██    ██ ███████ ██");      
        Console.WriteLine("██      ██   ██ ██      ██      ██  ██      ██      ██      ██    ██        ██    ██ ██    ██ ██   ██ ██");      
        Console.WriteLine(" ██████ ██   ██ ███████  ██████ ██   ██     ███████ ██ ███████    ██         ██████   ██████  ██   ██ ███████\n");
    }
    private  void AsciiArtFinalMessage()
    {
        Console.WriteLine("          ˚ ∧___∧   +        —̳͟͞͞💗");
        Console.WriteLine("           ( •‿• )つ  —̳͟͞͞ 💗         —̳͟͞͞💗 +");
        Console.WriteLine("           (つ   <                —̳͟͞͞💗");
        Console.WriteLine("            |   _つ      +  —̳͟͞͞💗         —̳͟͞͞💗 ˚");
        Console.WriteLine("           `し´\n\n\n\n");
    }


    // 3 method
    private  void DisplayPlayerAwards()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nYou have accumulated a total of {_score} points. Glory degrees based on your current score is:\n");
        int level = _score;

        if ((level >= 0) && (level <= 2000))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Glory of the Stars\n\n");
            Console.WriteLine("               ⬛⬛⬛");
            Console.WriteLine("              ⬛🟨🟨🟨⬛");
            Console.WriteLine("             ⬛🟨🟨🟨🟨⬛");
            Console.WriteLine("            ⬛🟨🟨🟨🟨🟨🟨⬛");
            Console.WriteLine("          ⬛🟨🟨🟨🟨🟨🟨🟨🟨⬛");
            Console.WriteLine("         ⬛🟨🟨🟨🟨🟨🟨🟨🟨🟨⬛");
            Console.WriteLine("        ⬛🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨⬛");
            Console.WriteLine(" ⬛⬛⬛⬛🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨⬛⬛⬛⬛");
            Console.WriteLine("⬛🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨⬛");
            Console.WriteLine(" ⬛🟧🟨🟨🟨🟨🟨🟨⬜⬛🟨🟨⬜⬛🟨🟨🟨🟨🟨🟨🟧⬛");
            Console.WriteLine("  ⬛🟧🟨🟨🟨🟨🟨⬛⬛🟨🟨⬛⬛🟨🟨🟨🟨🟨🟧⬛");
            Console.WriteLine("   ⬛🟧🟨🟨🟨🟨⬛⬛🟨🟨⬛⬛🟨🟨🟨🟨🟧⬛");
            Console.WriteLine("     ⬛🟨🟨🟨🟧⬛🟨🟨⬛🟧🟨🟨🟨🟨⬛");
            Console.WriteLine("     ⬛🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨⬛");
            Console.WriteLine("      ⬛🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨⬛");
            Console.WriteLine("      ⬛🟧🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟧⬛");
            Console.WriteLine("      ⬛🟧🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟧⬛");
            Console.WriteLine("       ⬛🟨🟨🟧🟧🟧🟧🟧🟧🟧🟧🟨🟨⬛");
            Console.WriteLine("      ⬛🟧🟨🟧⬛⬛⬛⬛⬛⬛🟧🟨🟧⬛");
            Console.WriteLine("        ⬛🟧⬛          ⬛🟧⬛");
            Console.WriteLine("          ⬛             ⬛\n\n");

        }
        else if ((level > 2000) && (level <= 3000))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Glory of the Moon\n\n");
            Console.WriteLine("                          ⣤⣤⣤⣤⣤⣤⣤⣄⣀");
            Console.WriteLine("                             ⠛⠻⠿⢿⣿⣿⣿⣿⣿");
            Console.WriteLine("                                 ⠙⠻⣿⣿⣿⣿⣿⣿⣶");
            Console.WriteLine("           ⢸⣿⣷⣤                    ⠙⢿⣿⣿⣿⣿⣿⣿⣦");
            Console.WriteLine("           ⢸⣿⣿⣿⣿⣷⣄          ⠀⣀⣀⣀⣀⣀⣙⢿⣿⣿⣿⣿⣿⣿⣦⡀⠀");
            Console.WriteLine("            ⢿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿   ⣿⣿⣿⣿⣿⣿⣿⣄⠀");
            Console.WriteLine("            ⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿     ⢹⣿⣿⣿⣿⣿⣿⣿⣆");
            Console.WriteLine("            ⢠⣿⣿⣿⣿⡟⠹⠿⠟⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏      ⢿⣿⣿⣿⣿⣿⣿⣿⡆");
            Console.WriteLine("            ⠋⡬⢿⣿⣷⣤⣤⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟         ⣿⣿⣿⣿⣿⣿⣿⣿⡀");
            Console.WriteLine("           ⠰⡇⢸⡇⢸⣿⣿⣿⠟⠁⢀⣬⢽⣿⣿⣿⣿⣿⣿          ⣿⣿⣿⣿⣿⣿⣿⣿⣧");
            Console.WriteLine("           ⣼⣧⣈⣛⣿⣿⣿⡇⠀⠀⣾⠁⢀⢻⣿⣿⣿⣿⠇          ⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.WriteLine("           ⢹⣿⣿⣿⣿⣿⣿⣧⣄⣀⠙⠷⢋⣼⣿⣿⣿⡟          ⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.WriteLine("⡀           ⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣿⣿⣿⣿⡟           ⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.WriteLine("⣿⡄            ⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟             ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.WriteLine("⣿⣿⡄               ⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦        ⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀");
            Console.WriteLine("⠸⣿⣿⣄              ⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦    ⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.WriteLine(" ⢹⣿⣿⣧⡀           ⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.WriteLine("   ⣿⣿⣿⣷⣄        ⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏");
            Console.WriteLine("    ⠙⣿⣿⣿⣿⣿     ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋");
            Console.WriteLine("     ⠻⣿⣿⣿⣿⣿⣿⣿⣷⣶⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟");
            Console.WriteLine("      ⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟");
            Console.WriteLine("        ⠈⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠋");
            Console.WriteLine("           ⠙⠻⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠛⠉⠀");
            Console.WriteLine("                 ⠀⠈⠉⠉⠛⠛⠛⠛⠛⠛⠛⠋⠉⠉\n\n");
        }
        else if (level > 3000)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Glory of the Sun\n\n");
            Console.WriteLine("───────▄▄────────▄█▄────────▄▄───────");
            Console.WriteLine("───────█░█───────█░█───────█░█───────");
            Console.WriteLine("──▄▄────█░█──────█░█──────█░█────▄▄──");
            Console.WriteLine("──█░█────█░█─────█░█─────█░█────█░█──");
            Console.WriteLine("───█░█────█░█──███████──█░█────█░█───");
            Console.WriteLine("────█░█────█████░░░░░█████────█░█────");
            Console.WriteLine("─────█░█──██░░░░░░░░░░░░░██──█░█─────");
            Console.WriteLine("──────█░██░░░░░░░░░░░░░░░░░██░█──────");
            Console.WriteLine("───────██░░░███░░░░░░░░░░░░░██───────");
            Console.WriteLine("─▄▄▄▄▄▄██░░██░██░░░░░░░░░░░░░█▄▄▄▄▄▄─");
            Console.WriteLine("█░░░░░░█░░░█████░░░░█████░░░░█░░░░░░█");
            Console.WriteLine("─▀▀▀▀▀▀█░░░░███░░░░░░░░░░░░░░█▀▀▀▀▀▀─");
            Console.WriteLine("───────█░░░░░░░░░░░░░░░░░░░░░█───────");
            Console.WriteLine("───────██░░░░█░░░░░░░░░█░░░░░█───────");
            Console.WriteLine("──────█░██░░░░█░░░░░░░█░░░░░█░█──────");
            Console.WriteLine("─────█░█──█░░░░███████░░░░██─█░█─────");
            Console.WriteLine("────█░█────██░░░░░░░░░░░██────█░█────");
            Console.WriteLine("───█░█─────█░███████████░█─────█░█───");
            Console.WriteLine("──█░█─────█░█────█░█────█░█─────█░█──");
            Console.WriteLine("──▀▀─────█░█─────█░█─────█░█─────▀▀──");
            Console.WriteLine("────────█░█──────█░█──────█░█────────");
            Console.WriteLine("───────█░█───────█░█───────█░█───────");
            Console.WriteLine("───────▀▀────────▀█▀────────▀▀───────");
        }
    }

    // 4 method


    // 5 method



    // 7 method   
    private void RecordEvent()
    // RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    /*
    RecordEvent - This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete 
    and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording 
    the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    */
    {
        ListGoalNames();
        Console.Write("\nWhich of the following goals did you complete?:\n\n");
        int goalCompleteIndex = int.Parse(Console.ReadLine());

        Goal goalAccomplished = _goals[goalCompleteIndex - 1];
        goalAccomplished.SetIsCompleteToTrue();
        goalAccomplished.RecordEvent();
        _score += goalAccomplished.GetCurrentPoint();

        Console.ForegroundColor = ConsoleColor.Red;
        string congratMessage = $"\n ██████  ██████  ███    ██  ██████  ██████   █████  ████████ ██    ██ ██       █████  ████████ ██  ██████  ███    ██ ███████\n██      ██    ██ ████   ██ ██       ██   ██ ██   ██    ██    ██    ██ ██      ██   ██    ██    ██ ██    ██ ████   ██ ██\n██      ██    ██ ██ ██  ██ ██   ███ ██████  ███████    ██    ██    ██ ██      ███████    ██    ██ ██    ██ ██ ██  ██ ███████\n██      ██    ██ ██  ██ ██ ██    ██ ██   ██ ██   ██    ██    ██    ██ ██      ██   ██    ██    ██ ██    ██ ██  ██ ██      ██\n ██████  ██████  ██   ████  ██████  ██   ██ ██   ██    ██     ██████  ███████ ██   ██    ██    ██  ██████  ██   ████ ███████\n\n⏺️  You have obtained a total of: {goalAccomplished.GetSetPoint()} points\n⏺️  The total points you have accumulated is: {_score}\n\n";
        Console.WriteLine(congratMessage);
        DisplayPlayerInfo();
        Console.WriteLine("\nPress enter to start over 🙂\n");
        Console.ReadKey();

        Console.Clear();
        GoalManager goalManager = new();
        goalManager.Start();
    }

    // 8 method
    private void ListGoals()
    {
        ListGoalDetails();
    }

    // 9 method
    private void SaveGoal()
    {
        // The proposal is to create a folder to save the goals (Saves the list of goals to a file.)
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nWe are going to create a folder to save your goals, write below the name of the new folder you want to create:\n\n");
        string fileName = Console.ReadLine();

        using StreamWriter saveGoals = new($"{_folderPath}{fileName}.txt");
        saveGoals.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            saveGoals.WriteLine(goal.GetStringRepresentation());
        }
        _goals.Clear();
        Console.WriteLine($"\nYour folder {fileName} has been created successfully 🙂.");
        Console.WriteLine("\n------------------------------------------------------------------------------------------------\n");  
    }


    // 10 method
    private void LoadGoals()
    // LoadGoals - Loads the list of goals from a file.
    {
        string[] files = Directory.GetFiles(_folderPath);

        if (files.Length != 0)
        {
            Console.WriteLine("\nHere you can see a list of your folders:\n");
            foreach (string file in files)    
            {
                _count++;
                Console.WriteLine($"{_count}. {Path.GetFileNameWithoutExtension(file)}");
            }
            _count = 0;

            Console.Write("\nPlease enter the number of the folder you wish to open below:\n\n");
            int choosenFile = int.Parse(Console.ReadLine());
            string[] fileContent = File.ReadAllLines(files[choosenFile - 1]);

            _goals.AddRange(GoalObjects(fileContent));
        } 
        else Console.WriteLine("You have no goals saved in your folders at this time.");
    }


    // 11 method


    // 12 method
    

    // 13 method
    
    
    // 14 method
    private int SetBonusPoint()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nHow about we assign some bonuses to this objective? Write below how many bonuses you would like to win: ");
        int _bonusPoint = int.Parse(Console.ReadLine());
        return _bonusPoint;
    }

    // 15 method
    private int SetCheckListCount()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nNow we are going to assign the number of times you need to complete this objective to finish it 🤠\nEnter below how many times you need to do this objective: ");
        int _checklistCount = int.Parse(Console.ReadLine());
        return _checklistCount;
    }
    
    // 16 method
    private List<Goal> GoalObjects(string[] param)
    {
        _score = int.Parse(param[0]);
        char colon = ':';
        char pipe = '|';
        int start = 1;
        int end = param.Length;
        param = param.Where((value, index) => index >= start && index <= end).ToArray();

        List<Goal> initialGoal = new();

        foreach (string list in param)
        {
            string[] parts = list.Split(colon);
            string nameOfTheGoal = parts[0].Trim();
            string[] contents = parts[1].Split(pipe);

            if (nameOfTheGoal == "Simple Goal")
            {
                SimpleGoal simpleGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: nameOfTheGoal);
                bool isComplete = bool.Parse(contents[3]);
                if (isComplete) 
                {
                    simpleGoal.SetCheckMark();
                    simpleGoal.SetIsCompleteToTrue();
                }
                initialGoal.Add(simpleGoal);
            }
            if (nameOfTheGoal == "Eternal Goals")
            {
                EternalGoal eternalGoal = new (name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: nameOfTheGoal);
                initialGoal.Add(eternalGoal);
            }
            if (nameOfTheGoal == "Checklist Goals")
            {
                CheckListGoal checkListGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: nameOfTheGoal, bonus: int.Parse(contents[3].Trim()), target: int.Parse(contents[4].Trim()));
                bool isComplete = bool.Parse(contents[6]);
                if (isComplete)
                {
                    checkListGoal.SetCheckMark();
                    checkListGoal.SetIsCompleteToTrue();
                } 
                checkListGoal.AddSaveAmountCompleted(int.Parse(contents[5].Trim()));
                initialGoal.Add(checkListGoal);
            }
        }
        Console.WriteLine("\nUpload complete 😎");
        return initialGoal;

        // List of methods containing Ascii art
        

    }
}
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
    private List<Goal> _goals = new ();
    private int _score;
    private int _count = 0;
    private string _folderPath = "GoalFolder/";

    public void Start()
    {
        // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        string menuOptions = "\n   A. Create New Goal\n   B. List Goals\n   C. Save Goals\n   D. Load Goals\n   E. Record Event\n   F. Quit\n   G. See Awards";
        
        bool startAgain = true;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(menuOptions);
            Console.Write("\nSelect a choice from the menu: ");
            string option = Console.ReadLine().ToUpper();

            if (option == "A")
           {
                Console.WriteLine("");
                CreateGoal();
           }
           else if (option == "B")
           {
                Console.WriteLine("");
                ListGoalDetails();
           }
           else if (option == "C")
           {
                Console.WriteLine("");
                SaveGoal();
           }
           else if (option == "D")
           {
                Console.WriteLine("");
                LoadGoals();
           }
           else if (option == "E")
           {
                Console.WriteLine("");
                RecordEvent();
           }
           else if (option == "F")
           {
                DisplayFinalMessage();
                break;
           }
           else if (option == "G")
           {
                DisplayPlayerAwards();
           }

        } while (startAgain);
    }

    //****************************************** A. Create New Goal **************************************************************
    private void CreateGoal()
    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        Console.Clear();
        AsciiArtTypesOfGoals();
        string[] goalTypes = {"Simple Goal", "Eternal Goals", "Checklist Goals"};
        Console.WriteLine($"\nThe types of Goals are:\n\n   1. {goalTypes[0]}\n   2. {goalTypes[1]}\n   3. {goalTypes[2]}");
        //Console.WriteLine($"\nThe types of Goals are:  1. {goalTypes[0]} (Are those that can be accomplished in a week or two)\n\n | 2. {goalTypes[1]}: (The most important goals in life that will give you joy as you fulfill your mission on this earth.)\n\n   3. {goalTypes[2]}: (goal that must be accomplished a certain number of times to be complete.)\n");
        Console.Write("\nWhich type of goal would you like to create? ");
        int typeOfGoal = int.Parse(Console.ReadLine()) - 1;

        if (typeOfGoal == 0)
        {
            Console.Clear();
            AsciiArtSimpleGoal();
            Console.WriteLine("Simple goals are those that you can achieve once you have done them and they will be marked as completed\nFor example: Give a Talk");
            SimpleGoal simpleGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal]);
            // Add goal to the list.
            _goals.Add(simpleGoal);
            MessageGoalCreate();
        }
        else if (typeOfGoal == 1)
        {
            Console.Clear();
            AsciiArtEternalGoal();
            Console.WriteLine("Eternal goals are those that will not be marked as completed since we must complete them forever\nFor example: Studying the scriptures");                                                                   
            EternalGoal eternalGoal = new (name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal]);
            // Add goal to the list.
            _goals.Add(eternalGoal);
            MessageGoalCreate();
        }
        else if (typeOfGoal == 2)
        {
            Console.Clear();
            AsciiArtchecklistGoal();
            Console.WriteLine("The Checklist Goals are those that we must do a certain number of times to mark them as completed\nFor example: Go to the Temple 3 times");
            CheckListGoal checkListGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal], target: SetCheckListCount(), bonus: SetBonusPoint());
            // Add goal to the list.
            _goals.Add(checkListGoal);
            MessageGoalCreate();
        }
        else
        {
            Console.WriteLine("Follow the program instructions 🫡, remember there are only three types of Goals, you must select a correct option.");
            GoCreateGoal();
        }
    }

    //****************************************** B. List Goals ***************************************************************
    private void ListGoalDetails()
    // Lists the details of each goal (including the checkbox of whether it is complete).
    {
        Console.Clear();
        AsciiArtListGoals();
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
            NoGoalsMessage();
        }
    }
    //****************************************** C. Save Goals **********************************************************

    private void SaveGoal()
    {
        // Saves the list of goals to a file.
        Console.Clear();
        AsciiArtSaveGoals();
        Console.Write("What is the filename for the goal file?: ");
        string fileName = Console.ReadLine();

        using StreamWriter saveGoals = new($"{_folderPath}{fileName}.txt");
        saveGoals.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            saveGoals.WriteLine(goal.GetStringRepresentation());
        }
        _goals.Clear();

        Console.WriteLine($"\nYour goals were successfully saved to the folder {fileName} 🙂."); 
    }

    //****************************************** D. Load Goals **********************************************************

    private void LoadGoals()
    // Loads the list of goals from a file.
    {
        Console.Clear();
        AsciiArtLoadGoals();
        string[] files = Directory.GetFiles(_folderPath);

        if (files.Length != 0)
        {
            Console.WriteLine("Here you can see a list of your folders:\n");
            foreach (string file in files)    
            {
                _count++;
                Console.WriteLine($"{_count}. {Path.GetFileNameWithoutExtension(file)}");
            }
            _count = 0;

            Console.Write("\nPlease enter the number of the folder you wish to load below:\n\n");
            int choosenFile = int.Parse(Console.ReadLine());
            string[] fileContent = File.ReadAllLines(files[choosenFile - 1]);

            _goals.AddRange(GoalObjects(fileContent));
        } 
        else Console.WriteLine("You have no goals saved in your folders at this time.");
    }

    //****************************************** E. Record Event **********************************************************
    private void RecordEvent()
    /*
    Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    This method should do whatever is necessary for each specific kind of goal:
        - Marking a simple goal complete 
        - Adding to the number of times a checklist goal has been completed. 
        - It should return the point value associated with recording 
        - May contain a bonus in some cases if a checklist goal was just finished.
    */
    {
        Console.Clear();
        AsciiArtRecordEvent();
        ListGoalNames();
        Console.Write("\nWhich of the following Goal did you complete?:\n\n");
        int goalCompleteIndex = int.Parse(Console.ReadLine());

        Goal goalAccomplished = _goals[goalCompleteIndex - 1];
        goalAccomplished.SetIsCompleteToTrue();
        goalAccomplished.RecordEvent();
        _score += goalAccomplished.GetCurrentPoint();

        AsciiArtCongratulations();
        Console.WriteLine($"------- 🎉 You have earned {goalAccomplished.GetSetPoint()} points!"); 
        Console.WriteLine($"------- 🎊 You now have {_score} points.");   
        Start();
    }

    //******************************************** Setters **************************************************************
    private string SetGoalName()
    {
        Console.Write("\nNow let's give this Goal a name 🥰, write the name you would like to give it\n - ");
        string _goalname = Console.ReadLine();
        return _goalname;
    }
    private string SetGoalDescription()
    {
        Console.Write("\nWrite a short description of your goal\n - ");
        string _goalDescription = Console.ReadLine();
        return _goalDescription;
    }
    private int SetGoalPoint()
    {
        Console.Write("\nEnter the amount of points you want to earn by completing this goal\n - ");
        int _goalPoint = int.Parse(Console.ReadLine());
        return _goalPoint;
    }
        private int SetBonusPoint()
    {
        Console.Write("\nHow about we assign some bonuses to this objective? Write below how many bonuses you would like to win: ");
        int _bonusPoint = int.Parse(Console.ReadLine());
        return _bonusPoint;
    }
    private int SetCheckListCount()
    {
        Console.Write("\nNow we are going to assign the number of times you need to complete this objective to finish it 🤠\nEnter below how many times you need to do this objective: ");
        int _checklistCount = int.Parse(Console.ReadLine());
        return _checklistCount;
    }

    //****************************************** Other functions ********************************************************
    private  void DisplayFinalMessage()
    {
        Console.WriteLine("\nHave a day full of many successes, see you soon.\n\n\n");
        AsciiArtFinalMessage();
    }
    private  void DisplayPlayerInfo()
    {
        // Displays the players current score.
        Console.WriteLine($"\n⭐️ ------ You have {_score} points ------ ⭐️");
    }
    private void MessageGoalCreate()
    {
        Console.WriteLine("\nYour goal has been successfully created\n");
        Console.WriteLine(" 🔴 Remember to save your Goals before Quit the program by selecting Choice 'C' from the main menu 🔴");
        Start();
    }
    private void NoGoalsMessage()
    {
        Console.WriteLine("I don't have any goals to show you. You could:\n\n - Create new goals by selecting option 'A' from the main menu\n - Load your previous Goals by selecting option 'D' from the main menu");
        Start();
    }
    /*
    private void GoMainMenu()
    {
        Console.WriteLine("\n Please press enter to go to the main menu 🙂\n");
        Console.ReadKey();
        Console.Clear();
        Start();
    }
    */
    private void ListGoalNames()
    // Lists the names of each of the goals.
    {
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
            NoGoalsMessage();
        }
    }
    private void GoCreateGoal()
    {
        Console.WriteLine("\n Please press enter to go to the main menu 🙂\n");
        Console.ReadKey();
        Console.Clear();
        CreateGoal();
    }
    
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
    }
    //****************************************** Ascii Art **************************************************************

    private  void AsciiArtTypesOfGoals()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n████████ ██    ██ ██████  ███████ ███████      ██████  ███████      ██████   ██████   █████  ██      ███████");
        Console.WriteLine("   ██     ██  ██  ██   ██ ██      ██          ██    ██ ██          ██       ██    ██ ██   ██ ██      ██");      
        Console.WriteLine("   ██      ████   ██████  █████   ███████     ██    ██ █████       ██   ███ ██    ██ ███████ ██      ███████"); 
        Console.WriteLine("   ██       ██    ██      ██           ██     ██    ██ ██          ██    ██ ██    ██ ██   ██ ██           ██"); 
        Console.WriteLine("   ██       ██    ██      ███████ ███████      ██████  ██           ██████   ██████  ██   ██ ███████ ███████\n");
    }
    private  void AsciiArtSimpleGoal()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n███████ ██ ███    ███ ██████  ██      ███████      ██████   ██████   █████  ██");      
        Console.WriteLine("██      ██ ████  ████ ██   ██ ██      ██          ██       ██    ██ ██   ██ ██");      
        Console.WriteLine("███████ ██ ██ ████ ██ ██████  ██      █████       ██   ███ ██    ██ ███████ ██");      
        Console.WriteLine("     ██ ██ ██  ██  ██ ██      ██      ██          ██    ██ ██    ██ ██   ██ ██");      
        Console.WriteLine("███████ ██ ██      ██ ██      ███████ ███████      ██████   ██████  ██   ██ ███████\n"); 
    }
    private  void AsciiArtEternalGoal()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n███████ ████████ ███████ ██████  ███    ██  █████  ██           ██████   ██████   █████  ██");      
        Console.WriteLine("██         ██    ██      ██   ██ ████   ██ ██   ██ ██          ██       ██    ██ ██   ██ ██");      
        Console.WriteLine("█████      ██    █████   ██████  ██ ██  ██ ███████ ██          ██   ███ ██    ██ ███████ ██");      
        Console.WriteLine("██         ██    ██      ██   ██ ██  ██ ██ ██   ██ ██          ██    ██ ██    ██ ██   ██ ██");      
        Console.WriteLine("███████    ██    ███████ ██   ██ ██   ████ ██   ██ ███████      ██████   ██████  ██   ██ ███████\n"); 
    }
    private  void AsciiArtchecklistGoal()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n ██████ ██   ██ ███████  ██████ ██   ██     ██      ██ ███████ ████████      ██████   ██████   █████  ██");      
        Console.WriteLine("██      ██   ██ ██      ██      ██  ██      ██      ██ ██         ██        ██       ██    ██ ██   ██ ██");      
        Console.WriteLine("██      ███████ █████   ██      █████       ██      ██ ███████    ██        ██   ███ ██    ██ ███████ ██");      
        Console.WriteLine("██      ██   ██ ██      ██      ██  ██      ██      ██      ██    ██        ██    ██ ██    ██ ██   ██ ██");      
        Console.WriteLine(" ██████ ██   ██ ███████  ██████ ██   ██     ███████ ██ ███████    ██         ██████   ██████  ██   ██ ███████\n");
    }
    private  void AsciiArtCongratulations()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n ██████  ██████  ███    ██  ██████  ██████   █████  ████████ ██    ██ ██       █████  ████████ ██  ██████  ███    ██ ███████"); 
        Console.WriteLine("██      ██    ██ ████   ██ ██       ██   ██ ██   ██    ██    ██    ██ ██      ██   ██    ██    ██ ██    ██ ████   ██ ██");      
        Console.WriteLine("██      ██    ██ ██ ██  ██ ██   ███ ██████  ███████    ██    ██    ██ ██      ███████    ██    ██ ██    ██ ██ ██  ██ ███████"); 
        Console.WriteLine("██      ██    ██ ██  ██ ██ ██    ██ ██   ██ ██   ██    ██    ██    ██ ██      ██   ██    ██    ██ ██    ██ ██  ██ ██      ██"); 
        Console.WriteLine(" ██████  ██████  ██   ████  ██████  ██   ██ ██   ██    ██     ██████  ███████ ██   ██    ██    ██  ██████  ██   ████ ███████\n\n"); 
    }
    private  void AsciiArtListGoals()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n██      ██ ███████ ████████      ██████   ██████   █████  ██      ███████");
        Console.WriteLine("██      ██ ██         ██        ██       ██    ██ ██   ██ ██      ██");      
        Console.WriteLine("██      ██ ███████    ██        ██   ███ ██    ██ ███████ ██      ███████");
        Console.WriteLine("██      ██      ██    ██        ██    ██ ██    ██ ██   ██ ██           ██"); 
        Console.WriteLine("███████ ██ ███████    ██         ██████   ██████  ██   ██ ███████ ███████\n\n"); 
    }
    private  void AsciiArtSaveGoals()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n███████  █████  ██    ██ ███████      ██████   ██████   █████  ██      ███████"); 
        Console.WriteLine("██      ██   ██ ██    ██ ██          ██       ██    ██ ██   ██ ██      ██");      
        Console.WriteLine("███████ ███████ ██    ██ █████       ██   ███ ██    ██ ███████ ██      ███████"); 
        Console.WriteLine("     ██ ██   ██  ██  ██  ██          ██    ██ ██    ██ ██   ██ ██           ██"); 
        Console.WriteLine("███████ ██   ██   ████   ███████      ██████   ██████  ██   ██ ███████ ███████"); 
    }
    private  void AsciiArtLoadGoals()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n██       ██████   █████  ██████       ██████   ██████   █████  ██      ███████"); 
        Console.WriteLine("██      ██    ██ ██   ██ ██   ██     ██       ██    ██ ██   ██ ██      ██");      
        Console.WriteLine("██      ██    ██ ███████ ██   ██     ██   ███ ██    ██ ███████ ██      ███████"); 
        Console.WriteLine("██      ██    ██ ██   ██ ██   ██     ██    ██ ██    ██ ██   ██ ██           ██"); 
        Console.WriteLine("███████  ██████  ██   ██ ██████       ██████   ██████  ██   ██ ███████ ███████\n\n"); 
    }
    private  void AsciiArtRecordEvent()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n██████  ███████  ██████  ██████  ██████  ██████      ███████ ██    ██ ███████ ███    ██ ████████");
        Console.WriteLine("██   ██ ██      ██      ██    ██ ██   ██ ██   ██     ██      ██    ██ ██      ████   ██    ██");    
        Console.WriteLine("██████  █████   ██      ██    ██ ██████  ██   ██     █████   ██    ██ █████   ██ ██  ██    ██");   
        Console.WriteLine("██   ██ ██      ██      ██    ██ ██   ██ ██   ██     ██       ██  ██  ██      ██  ██ ██    ██");    
        Console.WriteLine("██   ██ ███████  ██████  ██████  ██   ██ ██████      ███████   ████   ███████ ██   ████    ██\n");    
    }                                                                          
                                                                               

    private  void AsciiArtFinalMessage()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("          ˚ ∧___∧   +        —̳͟͞͞💗");
        Console.WriteLine("           ( •‿• )つ  —̳͟͞͞ 💗         —̳͟͞͞💗 +");
        Console.WriteLine("           (つ   <                —̳͟͞͞💗");
        Console.WriteLine("            |   _つ      +  —̳͟͞͞💗         —̳͟͞͞💗 ˚");
        Console.WriteLine("           `し´\n\n\n\n");
    }

    private  void DisplayPlayerAwards()
    {
        Console.WriteLine($"\nYou have accumulated a total of {_score} points. Glory degrees based on your current score is:\n");
        int level = _score;

        if ((level >= 0) && (level <= 2000))
        {
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
}
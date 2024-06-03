using System;
/*This program is designed to track the following exercises: 
Run
stationary bikes
Swim in the lap pool

Creates at least one activity of each type. 
Put each of these activities in the same list. 
Then iterate through this list and call the GetSummary method on each item and display the results.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Clear();
        Console.WriteLine("\n\n           █████   ██████ ████████ ██ ██    ██ ██ ████████ ██    ██     ████████ ██████   █████   ██████ ██   ██ ███████ ██████");  
        Console.WriteLine("          ██   ██ ██         ██    ██ ██    ██ ██    ██     ██  ██         ██    ██   ██ ██   ██ ██      ██  ██  ██      ██   ██");
        Console.WriteLine("          ███████ ██         ██    ██ ██    ██ ██    ██      ████          ██    ██████  ███████ ██      █████   █████   ██████");  
        Console.WriteLine("          ██   ██ ██         ██    ██  ██  ██  ██    ██       ██           ██    ██   ██ ██   ██ ██      ██  ██  ██      ██   ██"); 
        Console.WriteLine("          ██   ██  ██████    ██    ██   ████   ██    ██       ██           ██    ██   ██ ██   ██  ██████ ██   ██ ███████ ██   ██\n\n"); 

        // Put each of these activities in the same list.
        List<Activity> activities = new();

        string UserChoice;

        do
        {
            Console.WriteLine("\nPlease select one of the following activities:\n\n");
            Console.WriteLine("⭐️ A. Running\n⭐️ B. Cycling\n⭐️ C. Swimming\n⭐️ D. Get Track Summary\n⭐️ E. Quit\n");
            
            UserChoice = Console.ReadLine().ToUpper();

            if (UserChoice == "A")
            {
            Console.WriteLine(""); 
            string RunningImage = """"
                                                    ,////,
                                                    /// 6|
                                                    //  _|
                                                   _/_,-'
                                              _.-/'/   \   ,/;,
                                           ,-' /'  \_   \ / _/
                                           `\ /     _/\  ` /
                                             |     /,  `\_/
                                             |     \'
                                /\_        /`      /\
                               /' /_``--.__/\  `,. /  \
                              |_/`  `-._     `\/  `\   `.
                                        `-.__/'     `\   |
                                                      `\  \
                                                        `\ \
                                                          \_\__
                                                           \___)  RUNNING
            """";
            Console.WriteLine(RunningImage);
            Console.WriteLine("");
            Running running = new();
            running.StartRunning();
            activities.Add(running);
            }

            else if(UserChoice == "B")
            {
            Console.WriteLine("");
            string BicycleImage = """"
                                                                              $"   *.
                                                  d$$$$$$$P"                  $    J
                                                      ^$.                     4r  "
                                                      d"b                    .db
                                                     P   $                  e" $
                                            ..ec.. ."     *.              zP   $.zec..
                                        .^        3*b.     *.           .P" .@"4F      "4
                                      ."         d"  ^b.    *c        .$"  d"   $         %
                                     /          P      $.    "c      d"   @     3r         3
                                    4        .eE........$r===e$$$$eeP    J       *..        b
                                    $       $$$$$       $   4$$$$$$$     F       d$$$.      4
                                    $       $$$$$       $   4$$$$$$$     L       *$$$"      4
                                    4         "      ""3P ===$$$$$$"     3                  P
                                     *                 $       """        b                J
                                      ".             .P                    %.             @
                                        %.         z*"                      ^%.        .r"
                                           "*==*""                             ^"*==*""       CYCLING
            """";
            Console.WriteLine(BicycleImage);
            Console.WriteLine("");
            Cycling cycling = new();
            cycling.StartCycling();
            activities.Add(cycling);
            }

            else if (UserChoice == "C")
            {
            Console.WriteLine("");
            string SwimImage = """"       

                           .-'~~'-.
                        .'         '.
                        /  .------.  \
                        | / _    _ \ |
                        |==(_)==(_)==|
                        \/     \    \/
                         :    ^^    ;
                          \  '=='  /
                           `-.__.-'   SWIMMING
            """";
            Console.WriteLine(SwimImage);
            Console.WriteLine("");
            Swimming swimming = new();
            swimming.StartSwimming();
            activities.Add(swimming);
            }

            // Then iterate through this list and call the GetSummary method on each item and display the results.
            else if (UserChoice == "D")
            {
                Console.WriteLine("\nBelow is a summary of tracking your activities:\n");
                foreach (Activity activity in activities)
                {
                    activity.GetSummary();
                }
            }

        } while (UserChoice != "E");
        Console.WriteLine("\nThank you for using the activity tracking program.\n\nHave a great day and see you next time 🙂\n\n");   
    }
} 
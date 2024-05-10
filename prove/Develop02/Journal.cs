using System.IO;
/*
The responsibility of this class is to save and load the Journal entries into a txt file. 
The name of this file is saved and the date of the entry is stored.
*/
public class Journal
{
    public string _date = "";
    public string _fileName = "";
    private string _journalFilesPath = $"journalfiles/";
    private string txtName;

    public string fileAccessName (string fileName)
    {
        /*
        This method takes the file name as user input,
        removes all whitespace and replaces it with an underscore '_'.
        Returns: a string with an underscore
        */

        _fileName = fileName;
        txtName = _fileName.Replace(" ", "_").ToLower();
        _journalFilesPath += txtName;
        return _journalFilesPath;
    }

    public string Entry ( string Question, string NewFile = "")
    {
        /*
        This method This class is responsible for saving the file name, system date, 
        user question and answer in the journalfiles folder.
        Returns the file path that will be used by other methods.
        */
        
        using(StreamWriter outputFile = new StreamWriter($"{NewFile}.txt"))
        {
            Console.WriteLine(Question);
            string output = Console.ReadLine();
            outputFile.WriteLine($"-------------------\nFile Name: {_fileName}\n-------------------\n--------------------\nDate of Entry: {_date}\n--------------------\nQuestion: {Question}\n🌺 Answer: {output}");
            Console.WriteLine("");
            Console.WriteLine("A new memory has been successfully saved to your file 🙂");
        }
        return NewFile;
    }

    private void Save (string content, string [] file, int option)
    {
        /*
        This method saves the content of the magazine and gives the user
        an option to save or not save the entry.
        Don't return anything
        */
        
        string UserChoice = "exit";
        do
        {
            Console.Write("I always like to know what you do in your day, choose between these options:\n\n⏺️  Do you want me to save what you wrote? type 👉 yes\n⏺️  You do not want it to save what you wrote, type 👉 no\n⏺️  Do you want to return to the initial menu?, type 👉 exit\n\n");
            UserChoice = Console.ReadLine().ToLower();
        
            if (UserChoice == "yes")
            {
                File.AppendAllText(file[option - 1], $"{content}");
                Console.WriteLine("\nMission accomplished 😎\n");
                break;
            } 
            else if (UserChoice == "no")
            {  
                File.AppendAllText(file[option - 1], $"\n{content}");
                Console.WriteLine("\nMission accomplished 🤗 I don't want to remember that either.\n");
                content = Console.ReadLine();
            }
        } while (UserChoice != "exit");
        
    }
    public void Continue (string Question)
    {
        /*
        This method handles the user's choice to continue journaling.
        Makes use of the display class to display the current saved files for the user to choose from.
        I don't return anything
        */

        string theQuestion = Question;

        DisplayJournal display = new();
        string [] files = display.CurrentFile();

        Console.Write("\nChoose from the files above you would like to continue with: ");
        int option = int.Parse(Console.ReadLine());

        Console.WriteLine(theQuestion);
        string newEntry = Console.ReadLine();
        string content = $"Question: {theQuestion}\n🌺 Answer: {newEntry}\n";
        Console.WriteLine("");

        Save(content, files, option);

    }

}
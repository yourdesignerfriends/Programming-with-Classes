public class DisplayJournal
/*
The code is accessible for all classes
It is called a DisplayJournal since its objective is to print the options that the user has
*/
{
    private string _JournalFilesPath = $"journalfiles/";
    // Here I am telling the program the path where the journal files are located.
    private string _QuestionsPath = "prompts/questions.txt";
    // Here I am telling the system what is the path of the questions that the user will answer when writing in the diary.
    private List<string> theList = new();
    public void ShowMenu()
    {
        Console.WriteLine("Please select one of the following options:\n \n⏺️  1 - Start a new file in your Journal 🖌️\n⏺️  2 - Do you want to write something else in one of your Journal files? 🤓\n⏺️  3 - Do you want me to show you what you have written in your Journal? 🔑\n⏺️  4 - Delete your journal (this action is irreversible) 😔\n⏺️  5 - Do you want to close the program?\n");
    }

    public string [] CurrentFile()
    {
        /*
        This method gets the saved journal files from the directory, loops through the files and displays them for the user to choose which files wants to access. 
        Returns a list of strings (files)
        */
        int indexNum = 0;  
        var files = Directory.GetFiles(_JournalFilesPath); 
        Console.WriteLine("These are all the files I have in your Journal 🤓 📚\n");

        foreach (string file in files)    
        {
            indexNum ++;
            Console.WriteLine($"{indexNum}. {Path.GetFileNameWithoutExtension(file)}");
        }
        return files;
    }

    public void SaveJournal ()
    {
        /*
        This method calls CurrentFiles where the uploaded files are displayed,
        gets user input about the file that needs to be saved and informs the user that the file has been saved.
        does not return anything
        */
        string [] file = CurrentFile();
        Console.Write("\nChoose one of the files so I can show you what it contains: ");
        int userChoice = int.Parse(Console.ReadLine());

        string fileContent = File.ReadAllText(file[userChoice - 1]);
        Console.WriteLine($"\n{fileContent}");
        Console.WriteLine("\nA personal journal gives us an opportunity to reflect on our lives and recognize the many blessings God has given us 😇\n");

    }

    public void FileDelete ()
    {
        /*
        This method deletes a journal file from the journal folder, calls the CurrentFile method, which displays the saved files, gets the user's response as to which file should be deleted, and tells the user
        the file has been deleted.
        does not return anything
        */
        string [] file = CurrentFile();
        Console.Write("\nWhat file do you want me to show you?: ");
        int userChoice = int.Parse(Console.ReadLine());

        string delete = file[userChoice - 1];
        if (File.Exists(delete))
        {
            Console.WriteLine($"\n{Path.GetFileNameWithoutExtension(delete)} This file has been erased forever 🔥📝🔥");
            File.Delete(delete);
        }
        else
        {
            Console.WriteLine("Sorry, I can't find this file.");
        }
    }

    public string GetQuestion ()
    {
        /*
        This method gets the Question, stores them in a list,
        Generate a random number based on the length of the Questions list.
        Gets a random message, removes it from the list, and adds it to another list
        Returns a string (theQuestion)
        */
        Random random = new();
        List<string> Questions = new();
        Questions.AddRange(File.ReadAllLines($"{_QuestionsPath}"));
        int randomIndex = random.Next(Questions.Count());
        string theQuestion = Questions[randomIndex];
        theList.Add(theQuestion);
        Questions.RemoveAt(randomIndex);
        if (Questions.Count() == 0)
        {
            Questions.AddRange(theList);
        }
        return theQuestion;
    }

}
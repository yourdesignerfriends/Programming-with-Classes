using System;
/*
Program specification:
This program keeps track of YouTube videos and the comments left on them. 
For this assignmentyou will only have to worry about storing the information of a video and the comments.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("\n\n\n██╗   ██╗ ██████╗ ██╗   ██╗████████╗██╗   ██╗██████╗ ███████╗");
        Console.WriteLine("╚██╗ ██╔╝██╔═══██╗██║   ██║╚══██╔══╝██║   ██║██╔══██╗██╔════╝");
        Console.WriteLine(" ╚████╔╝ ██║   ██║██║   ██║   ██║   ██║   ██║██████╔╝█████╗");  
        Console.WriteLine("  ╚██╔╝  ██║   ██║██║   ██║   ██║   ██║   ██║██╔══██╗██╔══╝");  
        Console.WriteLine("   ██║   ╚██████╔╝╚██████╔╝   ██║   ╚██████╔╝██████╔╝███████╗");
        Console.WriteLine("   ╚═╝    ╚═════╝  ╚═════╝    ╚═╝    ╚═════╝ ╚═════╝ ╚══════╝\n\n");
        Console.ForegroundColor = ConsoleColor.Black;

        List<Video> videos = new();
        void DisplayVideo()
        {
            int count = 0;
            foreach (Video video in videos)
            {
                count++;
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("");
                Print($"🎥 Video number: {count}\n");
                video.DisplayInfo();

                Console.WriteLine("");
                Print("⏺️  Comments:\n");
                video.AddComment();
            }
        }
        /*
        Once you have the classes in place, write a program that creates 3-4 videos, 
        sets the appropriate values, and for each one add a list of 3-4 comments 
        (with the commenter's name and text). Put each of these videos in a list.
        */
        
        // ******************************************** Video 1 **************************************************************
        Video FirstVideo = new();
        FirstVideo.SetVideo("GokuroGaming", "Mario Kart 8 Deluxe", 37);
        videos.Add(FirstVideo);
        // Comments
        Comment comment = new("@AnitaIce", "If we ever get a Mario Kart 9, I hope we get more tracks like Piranha Plant Cove");
        FirstVideo.SetComment(comment);
        comment = new("@Cookie77", "I love this. My favorite is iggy koopa");
        FirstVideo.SetComment(comment);
        comment = new("@TheGhostHunter", "My favourite Mario character is Rosalina 😎");
        FirstVideo.SetComment(comment);
        

        // ************************************************* Video 2 **********************************************************
        Video SecondVideo = new();
        SecondVideo.SetVideo("Korokashi", "Killed ALL enemies on the Great Plateau in Ultimate Zelda", 60);
        videos.Add(SecondVideo);
        // Comments
        comment = new("@TheShadowKeeper", "In the name of goddess Hylia prepare to catch these hands 😂");
        SecondVideo.SetComment(comment);
        comment = new("@TheTerrestrialAlien", "WHOA, DUDE!!! You totally annihilated those enemies And BREAKNECK SPEED!!!");
        SecondVideo.SetComment(comment);
        comment = new("@SpringFlower", "You are a Peerless Master There is no doubt 🙏");
        SecondVideo.SetComment(comment);
        
        
        // ************************************************** Video 3 **********************************************************
        Video ThirdVideo = new();
        ThirdVideo.SetVideo("Nitrilo", "N64 Goldeneye", 70);
        videos.Add(ThirdVideo);
        // Comments
        comment = new("@TheJumpingRabbit", "0:19 - Natalya dies from 1 shot");
        ThirdVideo.SetComment(comment);
        comment = new("@TheAgent07", "To this day, I'm still fully convinced the AK-47 is a pencil");
        ThirdVideo.SetComment(comment);
        comment = new("@Carla7809", "Nostalgia at it's finest.  Takes me back to a simpler time in the 90's.");
        ThirdVideo.SetComment(comment);
        
        DisplayVideo();

    }
    public static void Print(string text, int speed = 100)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(speed);
        }
        Console.WriteLine();
    }
}
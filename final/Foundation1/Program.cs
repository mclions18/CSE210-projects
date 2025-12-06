using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();
        Video video1 = new Video("Speedrunning Every Daily Game", "Smant", 3517);
        Comment comment1_1 = new Comment("@nshelekhov","Oh yeas, my favorite artist, Bablo Picasso");
        video1.AddComment(comment1_1);
        Comment comment2_1 = new Comment("@phos4us","As soon as I saw the explosion I thought of the Rambo movies yet I never watched those movies. It just gave the vibe.");
        video1.AddComment(comment2_1);
        Comment comment3_1 = new Comment("@vlorpflash112","yeah we might need a geography training arc");
        video1.AddComment(comment3_1);
        _videoList.Add(video1);
        Video video2 = new Video("I tried Switching to Linux for 157 days", "Basically Homeless", 1794);
        Comment comment1_2 = new Comment("@Waitwhat469","Dudes vibe system administrating lol");
        video2.AddComment(comment1_2);
        Comment comment2_2 = new Comment("@muj0","I tried switching to lunix for 7000 days. Still not sure about it.");
        video2.AddComment(comment2_2);
        Comment comment3_2 = new Comment("@DorE3k","letting an AI agent hallucinate whatever it wants into your terminal while modifying critical system files is wild");
        video2.AddComment(comment3_2);
        _videoList.Add(video2);
        Video video3 = new Video("How to Hide a Wii (U) in a Computer", "Bringus Studios", 3522);
        Comment comment1_3 = new Comment("@Cyranek","i realized how emotionally invested i was when the stray antennae almost bricked the build");
        video3.AddComment(comment1_3);
        Comment comment2_3 = new Comment("@angiogen","this is the coolest electrical hazard i've ever seen in my life");
        video3.AddComment(comment2_3);
        Comment comment3_3 = new Comment("@zinova8252","Now hide a PC inside a Wii");
        video3.AddComment(comment3_3);
        _videoList.Add(video3);
        foreach (Video v in _videoList)
        {
            v.Display();

        }
    }
}
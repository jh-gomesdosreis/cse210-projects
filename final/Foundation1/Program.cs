using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Bring Me to Life";
        video1._length = "249";
        video1._author = "Evanescence";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Daniel Eduardo";
        video1Comment1._commentText = "Their lyrics never disappoints.";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "John Doe";
        video1Comment2._commentText = "I love it!";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Emily Greagori";
        video1Comment3._commentText = "I was looking forward to this song for so long!";

        Video video2 = new Video();
        video2._title = "Bird Set Free";
        video2._length = "292";
        video2._author = "Sia";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Mario Ries";
        video2Comment1._commentText = "This is so good!";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Mary Beth";
        video2Comment2._commentText = "How can I download this music?";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Tony Capella";
        video2Comment3._commentText = "Is anyone else listening to this in repeat for the last four days?";

        Video video3 = new Video();
        video3._title = "A Lenda";
        video3._length = "300";
        video3._author = "Sandy & Junior";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Chiara Maggiorie";
        video3Comment1._commentText = "A classic!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Louis Smith";
        video3Comment2._commentText = "Such angelic voices!";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Chris Buetner";
        video3Comment3._commentText = "Yeah, it's alright";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Manny Menning";
        video3Comment4._commentText = "Their best music, by far!";

        //add comments to list for each video 
        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);
        video3._commentList.Add(video3Comment4);

        //add each video to videosList 
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }

    }
}
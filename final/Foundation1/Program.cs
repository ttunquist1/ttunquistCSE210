using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        // video 1
        Video video1 = new Video();
        video1._title = "Gangnum style";
        video1._length = "253";
        video1._author = "officialpsy";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Edward Carlson";
        video1Comment1._commentText = "Best song in all of existance.";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Roxy Valerie";
        video1Comment2._commentText = "Such a classic! I love it!";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Jenna Smith";
        video1Comment3._commentText = "This song is so catchy!";
        
        //  video 2
        Video video2 = new Video();
        video2._title = "How To Play Chess: The Ultimate Beginner Guide";
        video2._length = "1887";
        video2._author = "GothamChess";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Aric V.";
        video2Comment1._commentText = "This video taught be a lot of good strategies, thank you!";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Joseph Smith";
        video2Comment2._commentText = "This video is so helpful! I love how you explain everything so well.";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Russel Nelson";
        video2Comment3._commentText = "Chess is SO fun! Thank you for teaching me!";

        // video 3
        Video video3 = new Video();
        video3._title = "Eiffel 65 - Blue (Da Ba Dee) [Gabry Ponte Ice Pop Mix] (Original Video with subtitles)";
        video3._length = "219";
        video3._author = "Eiffel 65";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Kurt C.";
        video3Comment1._commentText = "Thank you so much for this song!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "David Guetta";
        video3Comment2._commentText = "Lets collaborate! I love your music!";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Megan Fox";
        video3Comment3._commentText = "You are so talented! I love your music!";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Donald Trump";
        video3Comment4._commentText = "This, is the best song, I, have ever heard!";

        //add comments to each video
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
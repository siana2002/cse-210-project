using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Tongan Dance", "John Stark", 200);
        Video video2 = new Video("Samoan Dance", "Tony Mark", 300);
        Video video3 = new Video("New Zealand Dance", "Presley Nae", 400);
        Video video4 = new Video("African Dance", "Jason Moa", 100);

        video1.AddComment(new Comment("Jason Tan", "Thank you for the amazing dance. "));
        video1.AddComment(new Comment("Jamie Tang", "Keep up the good work. "));
        video1.AddComment(new Comment("Luke James", "Amazing traditional dance. "));
        video1.AddComment(new Comment("Alex Caruso", "Keeping it in the culture. "));

        video2.AddComment(new Comment("Victor Castle", "Can you please send the lyrics? "));
        video2.AddComment(new Comment("Stephen Curry", "What is the name of the song? "));
        video2.AddComment(new Comment("Jayson Tatum", "Love the traditional dance guys. "));
        video2.AddComment(new Comment("Jackie Chan", "Amazing performance guys. "));

        video3.AddComment(new Comment("Jack Brown", "Are you able to teach the dance to my family? "));
        video3.AddComment(new Comment("Bobby Tanga", "I would love to learn this dance. "));
        video3.AddComment(new Comment("Tippet Hons", "How much does it cost for your costumes? "));
        video3.AddComment(new Comment("Alex Glen", "Am I able to join the next time you guys perform? "));

        video4.AddComment(new Comment("Derrick White", "Where did you get your outfits from? "));
        video4.AddComment(new Comment("Kevin Heart", "Is this an African dance? "));
        video4.AddComment(new Comment("Monica Ting", "I love the african culture and performances. "));
        video4.AddComment(new Comment("Jessica Thompson", "I love being African. "));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title:  {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length in seconds: {video._length}");
            Console.WriteLine();

            Console.WriteLine("COMMENTS: ");
            foreach (Comment comment in video._commentList)
            {
                Console.WriteLine($"Commenter: {comment._name}, Comment: {comment._comment} ");
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
    }
}
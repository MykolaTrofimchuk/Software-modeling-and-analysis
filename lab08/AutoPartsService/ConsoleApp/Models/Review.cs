using System;

namespace AutoPartsService.Models
{
    public class Review
    {
        public int Rating { get; set; }
        public string Comment { get; set; }

        public void Edit(string newComment, int newRating)
        {
            Comment = newComment;
            Rating = newRating;
            Console.WriteLine("[Review] Відгук оновлено.");
        }
    }
}
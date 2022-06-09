using System;

namespace Circle.Models.Diary
{
    public class Diary
    {
        public string DiaryID { get; set; }

        public DateTime Date { get; set; }
        
        public string Title { get; set; }

        public string Text { get; set; }

        public string Author { get; set; }
        
    }
}
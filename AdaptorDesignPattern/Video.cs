using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern
{
    public class Video
    {
        public string Title { get; }
        public Video(string title)
        {
            this.Title = title;
        }
        public override string ToString()
        {
            return this.Title;
        }
    }
}

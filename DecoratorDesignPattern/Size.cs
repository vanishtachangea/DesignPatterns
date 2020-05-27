using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class Size
    {
        private Length Width { get; }
        private Length Length { get; }
        private Length Height { get; }
        public Size(Length width, Length length, Length height)
        {
            this.Width = width;
            this.Length = length;
            this.Height = height;
        }
        public Size Add(Size other) =>new Size(this.Width + other.Width, 
            this.Length + other.Length, this.Height + other.Height);

        public Size AddToTop(Size other) => new Size(this.Width.Max(other.Width), this.Length.Max(other.Length), this.Height.Add(other.Height));

        public Size ScaleHeight(decimal factor) => new Size(this.Width, this.Length, this.Height.Scale(factor));

        public override string ToString() => Length.ToString(" x ", this.Width, this.Length, this.Height);
        public static Size Zero => new Size(Length.Zero, Length.Zero, Length.Zero);

    }
}

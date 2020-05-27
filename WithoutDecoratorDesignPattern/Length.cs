using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorDesignPattern
{
    /// <summary>
    /// Copied from Tutorial : Not Written by myself ...
    /// </summary>
    public class Length
    {
        private decimal Meters { get; }
        private Length(decimal meters)
        {
            this.Meters = meters;
        }
        public static Length Zero => new Length(0);
        public static Length Millimeter => new Length(0.001M);

        public Length Add(Length other)
            => new Length(this.Meters + other.Meters);

        public Length Scale(decimal factor) => new Length(this.Meters * factor);
        public static Length operator +(Length a, Length b) =>
    new Length(a.Meters + b.Meters);

        public Length Max(Length other) => this.Meters >= other.Meters ? this : other;
        public static Length operator *(Length length, decimal factor) => new Length(length.Meters * factor);
        public static Length operator *(decimal factor, Length length) => (length * factor);

        public override string ToString() =>
          this.ToString(GetUserFriendlyScale(this.Meters));

        public static string ToString(string separator, params Length[] lengths) =>
            ToString(separator, lengths, GetGreatestScale(lengths));

        private static string ToString(string separator, IEnumerable<Length> lengths, (decimal factor, string unit) scale) =>
            ToString(separator, lengths, scale.factor, scale.unit);

        private static string ToString(string separator, IEnumerable<Length> lengths, decimal factor, string unit) =>
            $"{ToString(separator, lengths, factor)} {unit}";

        private static string ToString(string separator, IEnumerable<Length> lengths, decimal factor) =>
            string.Join(separator, lengths.Select(length => $"{length.Meters * factor:##.###}").ToArray());

        private static (decimal factor, string unit) GetGreatestScale(IEnumerable<Length> lengths) =>
            GetGreatestScale(lengths.Select(length => length.Meters));

        private static (decimal factor, string unit) GetGreatestScale(IEnumerable<decimal> meters) =>
            GetUserFriendlyScales(meters)
                .Aggregate((a, b) => a.factor >= b.factor ? a : b);

        private static IEnumerable<(decimal factor, string unit)> GetUserFriendlyScales(IEnumerable<decimal> meters) =>
            meters.Select(GetUserFriendlyScale);

        private static (decimal factor, string unit) GetUserFriendlyScale(decimal meters) =>
            meters < .01M ? (1000, "mm")
            : meters < 0.1M ? (100, "cm")
            : (1, "m");

        private string ToString((decimal factor, string unit) scale) =>
            this.ToString(scale.factor, scale.unit);

        private string ToString(decimal factor, string unit) =>
            $"{this.Meters * factor:##.###} {unit}";

    }
}

using System.Dynamic;

namespace PartialClass
{
    partial class Animal(string type, string? animalName = null, string? animalColor = null)
    {
        public string Type { get; set; } = type ?? "Unknown";
        public string AnimalColor { get; set; } = animalColor ?? "Unknown";
        public string AnimalName { get; set; } = animalName ?? "Unknown";
    }
}

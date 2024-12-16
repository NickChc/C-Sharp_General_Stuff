namespace PartialClass
{
    partial class Animal
    {
        public void DisplayName()
        {
            Console.WriteLine($"Name - {AnimalName} \nColor - {this.AnimalColor}");
        }

        public void DisplayType()
        {
            Console.WriteLine(Type);
        }

        public void DisplayColor()
        {
            Console.WriteLine(AnimalColor);
        }
    }
}

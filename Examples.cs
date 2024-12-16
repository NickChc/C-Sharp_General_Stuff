// FILES -------------------------------------------------


// namespace FileExcersize
// {
//     class Program
//     {
//         static readonly string currDir = @"C:\Users\nikac\Desktop\NIKA\C#\C#_1";
//         static readonly string workingDir = currDir + @"\languages";

//         static void Main(string[] args)
//         {
//             if (Directory.Exists(workingDir))
//             {
//                 ReadAllLangs();
//             }
//             else
//             {
//                 Directory.CreateDirectory(path: workingDir);

//                 Array languages = Enum.GetValues<ELang>();

//                 if (Directory.Exists(workingDir))
//                     for (int i = 0; i < languages.Length; i++)
//                     {
//                         ELang lang = (ELang)languages.GetValue(i)!;

//                         HandleFile(lang.ToString(), i);
//                     }
//             }
//         }

//         static void HandleFile(string lang, int index)
//         {
//             string langDir = workingDir + @$"\{lang}";
//             Directory.CreateDirectory(langDir);
//             string file = langDir + @"\log.txt";

//             using StreamWriter langSW = new(path: file);
//             langSW.WriteLine($"File no. {index + 1}, created on {DateTime.Now}");
//         }

//         static void ReadAllLangs()
//         {
//             ELang[] langauges = Enum.GetValues<ELang>();

//             foreach (ELang lang in langauges)
//             {
//                 string file = workingDir + @$"\{lang}\log.txt";
//                 using StreamReader langSR = new(file);
//                 string content = langSR.ReadToEnd();
//                 Console.WriteLine($"{lang.ToString().ToUpper()} - ");
//                 Console.WriteLine(content);
//             }
//         }
//     }

//     enum ELang
//     {
//         English,
//         Georgian,
//         Russian,
//         Italian,
//         Spanish,
//     }
// }








// namespace Files
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool isValidOperation = false;

//             while (!isValidOperation)
//             {
//                 Console.WriteLine("Chooseoperation type, enter - [\"read\" or \"write\"]");

//                 string opType = Console.ReadLine() ?? "";

//                 if (opType == "read")
//                 {
//                     ReadNames();
//                 }
//                 else if (opType == "write")
//                 {
//                     EnterNewName();
//                 }
//                 else
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine($"Invalid operation type \"{opType}\"");
//                     Console.ResetColor();
//                     continue;
//                 }
//                 isValidOperation = true;
//             }
//         }

//         static void ReadNames()
//         {
//             string workingDir = @"C:\Users\nikac\Desktop\NIKA\C#\C#_1\files";

//             bool isValid = false;

//             while (!isValid)
//             {
//                 try
//                 {
//                     Console.WriteLine("Names to read - [ \"male\", \"female\", \"all\" ]");

//                     string toRead = Console.ReadLine() ?? "all";

//                     if (toRead == "male")
//                     {
//                         string file = @$"{workingDir}\males\names.txt";

//                         if (File.Exists(file))
//                         {
//                             using StreamReader maleSR = new(file);
//                             string content = maleSR.ReadToEnd();
//                             Console.WriteLine("\n" + content);
//                         }
//                         else
//                         {
//                             Console.WriteLine("There are no male names");
//                             continue;
//                         }
//                     }
//                     else if (toRead == "female")
//                     {
//                         string file = @$"{workingDir}\females\names.txt";

//                         if (File.Exists(file))
//                         {
//                             using StreamReader femaleSR = new(file);
//                             string content = femaleSR.ReadToEnd();
//                             Console.WriteLine("\n" + content);
//                         }
//                         else
//                         {
//                             Console.WriteLine("There are no female names");
//                             continue;
//                         }
//                     }
//                     else if (toRead == "all")
//                     {
//                         string malesFile = @$"{workingDir}\males\names.txt";
//                         string femalesFile = @$"{workingDir}\females\names.txt";

//                         if (!File.Exists(malesFile) && !File.Exists(femalesFile))
//                         {
//                             Console.WriteLine("No names added yet");
//                             continue;
//                         }

//                         string maleContent = "";
//                         string femaleContent = "";

//                         if (File.Exists(malesFile))
//                         {
//                             using StreamReader maleSR = new(malesFile);
//                             maleContent = maleSR.ReadToEnd();
//                         }

//                         if (File.Exists(femalesFile))
//                         {
//                             using StreamReader femaleSR = new(femalesFile);
//                             femaleContent = femaleSR.ReadToEnd();
//                         }

//                         Console.WriteLine(
//                             $"MALE NAMES - \n\n{maleContent} \n\n ------------- \n\nFEMALE NAMES - \n\n{femaleContent}"
//                         );
//                     }
//                     else
//                     {
//                         throw new Exception($"Can't read {toRead} file");
//                     }

//                     isValid = true;
//                 }
//                 catch (Exception err)
//                 {
//                     Console.Clear();
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine(err.Message);
//                     Console.ResetColor();
//                 }
//             }
//         }

//         static void EnterNewName()
//         {
//             static void NameOrSurnameException(StreamWriter sw)
//             {
//                 sw.Close();
//                 throw new FormatException("Name or surname can't be empty");
//             }

//             bool isValid = false;

//             while (!isValid)
//             {
//                 try
//                 {
//                     string workingDir = @"C:\Users\nikac\Desktop\NIKA\C#\C#_1\files";

//                     string file = workingDir;

//                     Console.WriteLine("choose gender - [male / female]");
//                     string gender = Console.ReadLine()!;

//                     if (string.Equals(gender, "male"))
//                     {
//                         Directory.CreateDirectory(@$"{workingDir}\males");
//                         file += @"\males\names.txt";
//                         Console.Clear();
//                     }
//                     else if (string.Equals(gender, "female"))
//                     {
//                         Directory.CreateDirectory(@$"{workingDir}\females");
//                         file += @"\females\names.txt";
//                         Console.Clear();
//                     }
//                     else
//                     {
//                         throw new FormatException("Gender must be \"male\" or \"female\"");
//                     }

//                     StreamWriter namesSW = new(path: file, append: true);

//                     Console.WriteLine("Enter your name:");
//                     string name = Console.ReadLine() ?? "";

//                     if (name == string.Empty)
//                     {
//                         NameOrSurnameException(namesSW);
//                         return;
//                     }

//                     Console.Clear();
//                     Console.WriteLine("Enter your surname");
//                     string surname = Console.ReadLine() ?? "";

//                     if (surname == string.Empty)
//                     {
//                         NameOrSurnameException(namesSW);
//                         return;
//                     }

//                     namesSW.WriteLine($"{name} {surname}");

//                     isValid = true;

//                     namesSW.Close();
//                 }
//                 catch (Exception err)
//                 {
//                     Console.Clear();
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine(err.Message);
//                     Console.ResetColor();
//                 }
//             }
//         }
//     }
// }




// DOCUMENTATION - XML ----------------------------

// using System.Diagnostics;

// namespace Course
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Dog dog = new();

//             dog.Sit(dogName: "Max", trainerName: "Jake");

//             dog.Add(x: 5, y: 5);
//         }
//     }

//     interface IDogCommands
//     {
//         void Sit();
//         void Sit(string dogName, string trainerName);
//     }

//     /// <summary>
//     /// Class animal is a base class for child classes like "Dog"
//     /// </summary>
//     abstract class Animal
//     {
//         public virtual void MakeSound()
//         {
//             Console.WriteLine("Sound");
//         }
//     };

//     class Dog : Animal, IDogCommands
//     {
//         string DogName { get; set; } = "Unknown";

//         /// <summary>
//         /// This method makes the dog sit
//         /// </summary>
//         public void Sit()
//         {
//             Console.WriteLine("The dog sat!");
//         }

//         /// <summary>
//         /// Overloaded method that makes the dog sit
//         /// </summary>
//         /// <param name="dogName">The name of the dog</param>
//         /// <param name="trainerName">The name of the trainer</param>
//         public void Sit(string dogName, string trainerName)
//         {
//             Console.WriteLine($"{dogName} sat after {trainerName} gave a command");
//         }

//         public override void MakeSound()
//         {
//             if (string.Equals(DogName, "Unknown"))
//             {
//                 Console.WriteLine("An unknown dog barks");
//                 return;
//             }

//             Console.WriteLine($"The dog named {DogName} barks");
//         }

//         /// <summary>
//         /// Adds two integers and returns the sum
//         /// </summary>
//         /// <param name="x">First integer</param>
//         /// <param name="y">Second Integer</param>
//         /// <returns>The sum of two integers</returns>
//         public int Add(int x, int y)
//         {
//             return x + y;
//         }
//     }
// }




// namespace DogAssignment
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             GermanShephard germanShephard = new(
//                 name: "Shep",
//                 birthDate: new DateTime(2005, 10, 10),
//                 origin: "Germany",
//                 gender: "Male",
//                 weight: 44,
//                 securityGuard: true,
//                 training: ETrainingLvl.High,
//                 size: ESize.Big
//             );

//             germanShephard.SayHi();
//             germanShephard.SayHi(dogName: germanShephard.Name);
//         }
//     }

//     class Animal(string name, DateTime birthDate, string origin)
//     {
//         public string Name { get; set; } = name ?? "Unknown";

//         public DateTime BirthDate { get; set; } = birthDate;

//         public string Origin { get; set; } = origin ?? "Unkown";
//     }

//     interface IDog
//     {
//         void Eat();
//         void Drink();
//         void SayHi();
//         void Sit();
//     }

//     enum ETrainingLvl
//     {
//         Low,
//         Medium,
//         High,
//     }

//     enum ESize
//     {
//         Small,
//         Medium,
//         Big,
//         TooBig,
//     }

//     class GermanShephard(
//         string name,
//         DateTime birthDate,
//         string origin,
//         string gender,
//         float weight,
//         bool securityGuard,
//         ETrainingLvl training,
//         ESize size
//     ) : Animal(name, birthDate, origin), IDog
//     {
//         public string Gender { get; set; } = gender;

//         public float Weight { get; set; } = weight;

//         public bool SecurityGuard { get; set; } = securityGuard;

//         public ETrainingLvl Training { get; set; } = training;

//         public ESize Size { get; set; } = size;

//         public void DisplayInfo()
//         {
//             Console.WriteLine(
//                 $"The dog's name is {Name}, he was born in {origin}, {birthDate}. {Name} is {Gender} and weights around {Weight} kilos, it is a {Size} dog."
//             );
//         }

//         public void Eat()
//         {
//             Console.WriteLine("the dog is eating");
//         }

//         public void Drink()
//         {
//             Console.WriteLine("the dog is drinking");
//         }

//         public void Sit()
//         {
//             Console.WriteLine("the dog is sitting");
//         }

//         public void SayHi()
//         {
//             Console.WriteLine("the dog is saying hi");
//         }

//         public void SayHi(string dogName)
//         {
//             Console.WriteLine("Hello " + dogName);
//         }
//     }
// }



// namespace MovieStruct
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Movie movie = new()
//             {
//                 Name = "Godfather I",
//                 ReleaseDate = new DateTime(1972, 12, 2),
//                 Rate = 9.8f,
//                 Countries = [ECountries.UnitedStatesOfAmerica, ECountries.Italy],
//                 Genres = [EGenres.Drama, EGenres.Criminal, EGenres.Action],
//                 Languages = [ELanguages.English, ELanguages.Italian],
//             };
//         }
//     }

//     struct Movie()
//     {
//         public string Name { get; set; } = "Unknown";
//         public float Rate { get; set; } = 0;

//         public DateTime ReleaseDate { get; set; } = DateTime.Now;

//         public EGenres[] Genres { get; set; } = [];

//         public ELanguages[] Languages { get; set; } = [];

//         public ECountries[] Countries { get; set; } = [];

//         public void GetInfo()
//         {
//             string langsToDisplay = string.Empty;
//             string countriesToDisplay = string.Empty;
//             string genresToDisplay = string.Empty;

//             foreach (var genre in Genres)
//             {
//                 genresToDisplay += $"| {genre.ToString()}";
//             }

//             foreach (var country in Countries)
//             {
//                 countriesToDisplay += $"| {country.ToString()}";
//             }

//             foreach (var lang in Languages)
//             {
//                 langsToDisplay += $"| {lang.ToString()}";
//             }

//             Console.WriteLine(
//                 $"Movie: {Name} \nRate: {Rate} out of 10 \nReleased on: {ReleaseDate} \nLanguages: {langsToDisplay} \nGenres: {genresToDisplay} \nCountries: {countriesToDisplay}"
//             );
//         }
//     }

//     enum EGenres
//     {
//         Drama,
//         Comedy,
//         Action,
//         Horrow,
//         Criminal,
//     }

//     enum ELanguages
//     {
//         English,
//         Georgian,
//         Spanish,
//         German,
//         French,
//         Italian,
//     }

//     enum ECountries
//     {
//         UnitedStatesOfAmerica,
//         England,
//         Georgia,
//         Spain,
//         Germany,
//         France,
//         Italy,
//     }
// }



// Try Catch Finally -----------------

// namespace Test
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a,
//                 b;

//             double div = 0;

//             startAgain:
//             try
//             {
//                 Console.WriteLine("First Number -");
//                 a = int.Parse(Console.ReadLine() ?? "0");

//                 Console.WriteLine("Second Number -");
//                 b = int.Parse(Console.ReadLine() ?? "0");

//                 div = (double)a / (double)b;

//                 Console.WriteLine($"Result - {div}");
//             }
//             catch (DivideByZeroException err)
//             {
//                 Console.WriteLine(err.Message);
//                 goto startAgain;
//             }
//             catch (FormatException err)
//             {
//                 Console.WriteLine(err.Message);
//                 goto startAgain;
//             }
//         }
//     }
// }




// Enumerations ---------------------------

// namespace Enumerations
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string weekDayName = WeekDay.Friday.ToString();

//             WeekDay day = WeekDay.Friday;

//             Console.WriteLine((int)day);
//         }
//     }

//     enum WeekDay
//     {
//         Monday,
//         Tuesday,
//         Wednesday,
//         Thursday,
//         Friday = 40,
//         Saturday,
//         Sunday,
//     }
// }




// namespace Structs
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             StructTest structTest = new() { Name = "StructTest" };
//             StructTest structTestClone = structTest;

//             structTestClone.Name = "Clone name";

//             Console.WriteLine("HERE " + structTestClone.Name);

//             // structTest.Name = "New Name";

//             Console.WriteLine(structTest.Name, structTestClone.Name);
//         }
//     }

//     struct StructTest(string name)
//     {
//         public string Name { get; set; } = name ?? "StructTest";
//     }

//     class ClassTest
//     {
//         public static string Name { get; set; } = "ClassTest";
//     }

//     struct Employee
//     {
//         public string employeeName;
//         public string positionName;

//         private int _salary;

//         public int Salary
//         {
//             readonly get => _salary;
//             set => _salary = value;
//         }

//         public readonly void SayHi()
//         {
//             Console.WriteLine($"Hi from {employeeName}");
//         }

//         public Employee(string name, string posName, int salary)
//         {
//             employeeName = name ?? "Unknown";

//             positionName = posName ?? "Unknown";

//             Salary = salary;
//         }
//     }
// }


// using System.Dynamic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Animal animal = new();

//         var dog = new Animal.Dog();

//         var cat = new Animal.Cat();

//         _ = animal.Name;

//         _ = cat.CatName;

//         _ = dog.DogBreed;
//     }

//     class Animal
//     {
//         public string Name { get; set; }

//         public class Dog
//         {
//             public string DogBreed { get; set; }
//         }

//         public class Cat
//         {
//             public string CatName { get; set; }
//         }
//     }
// }



// namespace Scope
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Calc calc = new(); // Error - static class Calc

//             Console.WriteLine(Calc.Add(1, 2));
//         }
//     }

//     static class Calc
//     {
//         public static double Add(double a, double b)
//         {
//             return a + b;
//         }

//         public static double Sub(double a, double b)
//         {
//             return a - b;
//         }
//     }

//     // class Test : Calc;  // Error

//     // sealed class Animal
//     // {
//     //     public string Name { get; set; }
//     // }

//     // class Dog : Animal;
// }


// namespace Scope
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Car car = new();

// //             Console.WriteLine(Car.CarCount);
// //         }
// //     }

// //     #region Cars - This is a solution for the car excercise;
// //     class Car
// //     {
// //         #region Vars - declare variables here
// //         public static int CarCount { get; set; } = 0;

// //         #endregion vars

// //         public Car()
// //         {
// //             CarCount++;
// //         }
// //     }

// //     #endregion
// // }






// namespace Overriding
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Circle circle = new();

//             circle.Sayhi();

//             circle.Draw();
//         }
//     }

//     abstract class Shape
//     {
//         public abstract void Draw();

//         public void Sayhi()
//         {
//             Console.WriteLine("Saying hi from the abstract class");
//         }
//     }

//     class Circle : Shape
//     {
//         public override void Draw()
//         {
//             Console.WriteLine("Drawing");
//         }
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//         Shape[] shapes = [new(), new Circle(), new Triangle()];

//         foreach (var s in shapes)
//         {
//             s.Draw();
//         }
//     }
// }

// class Shape
// {
//     public virtual void Draw()
//     {
//         Console.WriteLine("I am a simple shape");
//     }
// }

// class Circle : Shape
// {
//     // use "new" to hide the warning
//     public new void Draw()
//     {
//         Console.WriteLine("I am a circle");
//     }
// }

// class Triangle : Shape
// {
//     // use "override" with "virtual" for actual overriding functionality
//     public override void Draw()
//     {
//         Console.WriteLine("I am a triangle");
//     }
// }


// class Vehicle
// {
//     public string Color { get; set; }
//     public string Manufacturer { get; set; }

//     public int MaxSpeed { get; set; }

//     public bool UsesGas { get; set; }

//     public bool UsesElectricity { get; set; }

//     public void Start()
//     {
//         Console.WriteLine("Vehicle started");
//     }

//     public void Stop()
//     {
//         Console.WriteLine("Vehicle stopped");
//     }

//     public void Drive()
//     {
//         Console.WriteLine("Vehicle is being driven");
//     }

//     public void RunAtMaxSpeed()
//     {
//         Console.WriteLine("Vehicle runs at max speed");
//     }

//     void TransportPeople()
//     {
//         Console.WriteLine("Vehicle is transporting people");
//     }

//     public Vehicle(
//         string color,
//         string manufacturer,
//         int maxSpeed,
//         bool usesGas = true,
//         bool usesElectricity = false
//     )
//     {
//         Color = color;
//         Manufacturer = manufacturer;
//         MaxSpeed = maxSpeed;
//         UsesGas = usesGas;
//         UsesElectricity = usesElectricity;
//     }
// }

// class WheeledVehicle : Vehicle
// {
//     public WheeledVehicle(
//         string color,
//         string manufacturer,
//         int maxSpeed,
//         bool usesGas = true,
//         bool usesElectricity = false
//     )
//         : base(color, manufacturer, maxSpeed, usesGas, usesElectricity) { }

//     public int WheelCount { get; set; }

//     public float WheelRadius { get; set; }
// }

// class FourWheeledVehice : WheeledVehicle
// {
//     public bool HasWinterTires { get; set; } = false;

//     public void CountWheels()
//     {
//         Console.WriteLine("I have 4 wheels");
//     }

//     public FourWheeledVehice(
//         string color,
//         string manufacturer,
//         int maxSpeed,
//         bool hasWinterTires,
//         bool usesGas = true,
//         bool usesElectricity = false
//     )
//         : base(color, manufacturer, maxSpeed, usesGas, usesElectricity)
//     {
//         HasWinterTires = hasWinterTires;
//     }
// }

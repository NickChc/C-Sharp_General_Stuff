// namespace Events
// {
//     public delegate void SayHiDel(string name);

//     class Program
//     {
//         public event SayHiDel MyEvent;

//         static void Main(string[] args)
//         {
//             Program prog = new();
//             prog.MyEvent("Dave");
//         }

//         public static void SayHiEnglish(string name)
//         {
//             Console.WriteLine("Hello " + name);
//         }

//         public static void SayHiGeorgian(string name)
//         {
//             Console.WriteLine("გამარჯობა " + name);
//         }

//         public static void SayHiSpanish(string name)
//         {
//             Console.WriteLine("Hola " + name);
//         }

//         public Program()
//         {
//             MyEvent += new SayHiDel(SayHiEnglish);
//             MyEvent += new SayHiDel(SayHiGeorgian);
//             MyEvent += new SayHiDel(SayHiSpanish);
//         }
//     }
// }






// More complicated example




// Same as below, but better structured -

// namespace Events
// {
//     public delegate void DisplayDateAfterDel();

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person person = new("Dave");

//             person.DisplayPlayerInformation("Dave");
//         }
//     }

//     // Creates a person with name and an instance of DisplayInfo. Has an event defined to pass to DisplayInfo.
//     // Has another method which calls the method from DisplayInfo that also executes the event;
//     class Person
//     {
//         public string Name { get; set; }
//         private readonly DisplayInfo displayInfoInstance;

//         // public Person()
//         // {
//         // displayInfoInstance = new(DisplayInfoInstance_DisplayDateAfterEvent);
//         // }

//         private void DisplayInfoInstance_DisplayDateAfterEvent()
//         {
//             Console.ForegroundColor = ConsoleColor.Blue;
//             Console.WriteLine($"The message was displayed at - {DateTime.Now.ToShortTimeString()}");
//             Console.ResetColor();
//         }

//         public void DisplayPlayerInformation(string name)
//         {
//             displayInfoInstance.DisplayPersonInfo(name);
//         }

//         public Person(string name)
//         {
//             Name = name ?? "Unkown";

//             displayInfoInstance = new(DisplayInfoInstance_DisplayDateAfterEvent);
//         }
//     }

//     // Displays a message and executes a method passed to it afterwards.
//     class DisplayInfo(DisplayDateAfterDel displayDateAfterEvent)
//     {
//         public event DisplayDateAfterDel DisplayDateAfterEvent = displayDateAfterEvent;

//         public void DisplayPersonInfo(string name)
//         {
//             Console.WriteLine(name);
//             DisplayDateAfterEvent();
//         }
//     }
// }



// Same as above, but a bit more complicated

// namespace Events
// {
//     public delegate void DisplayDateAfterDel();
//     public delegate void DisplayMessageBeforeDel();

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Football football = new();

//             Console.WriteLine();

//             football.DisplayClub("Barcelonna", "Spain");
//             football.DisplayPlayerInfo("Messi", "Barcelonna");
//         }
//     }

//     class Football
//     {
//         private DisplayInfo displayInfoInstance;

//         public Football()
//         {
//             displayInfoInstance = new(
//                 DisplayInfoInstance_DisplayDateAfterEvent,
//                 DisplayInfoInstance_DisplayMessageBeforeEvent
//             );
//         }

//         private void DisplayInfoInstance_DisplayDateAfterEvent()
//         {
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine(
//                 $"Information has been displayed on {DateTime.Now.ToShortTimeString()}"
//             );
//             Console.ResetColor();
//         }

//         private void DisplayInfoInstance_DisplayMessageBeforeEvent()
//         {
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine($"This message is displayed before");
//             Console.ResetColor();
//         }

//         public void DisplayClub(string club, string country)
//         {
//             displayInfoInstance.DisplayClub(club, country);
//         }

//         public void DisplayPlayerInfo(string name, string club)
//         {
//             displayInfoInstance.DisplayPlayer(name, club);
//         }
//     }

//     class DisplayInfo(
//         DisplayDateAfterDel displayDateAfterEvent,
//         DisplayMessageBeforeDel displayMessageBeforeEvent
//     )
//     {
//         public event DisplayDateAfterDel DisplayDateAfterEvent = displayDateAfterEvent;
//         public event DisplayMessageBeforeDel DisplayMessageBeforeEvent = displayMessageBeforeEvent;

//         public void DisplayClub(string clubName, string country)
//         {
//             DisplayMessageBeforeEvent();
//             Console.WriteLine($"{clubName} from {country}");
//             DisplayDateAfterEvent();
//             Console.WriteLine();
//         }

//         public void DisplayPlayer(string player, string clubName)
//         {
//             Console.WriteLine($"{player} plays for {clubName}");
//         }
//     }
// }

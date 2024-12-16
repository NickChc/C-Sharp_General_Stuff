// namespace DelegateMulticast
// {
//     public delegate void SayHiDel();

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             SayHiDel sayHi = new(SayHiArabic);

//             sayHi += new SayHiDel(SayHiChinese);
//             sayHi += new SayHiDel(SayHiEnglish);
//             sayHi += new SayHiDel(SayHiFrench);
//             sayHi += new SayHiDel(SayHiGerman);
//             sayHi += new SayHiDel(SayHiItalian);
//             sayHi += new SayHiDel(SayHiJapanese);
//             sayHi += new SayHiDel(SayHiPortuguese);
//             sayHi += new SayHiDel(SayHiRussian);
//             sayHi += new SayHiDel(SayHiSpanish);

//             sayHi();
//         }

//         // Say hi in English
//         public static void SayHiEnglish()
//         {
//             Console.WriteLine("Hello.");
//         }

//         // Say hi in Spanish
//         public static void SayHiSpanish()
//         {
//             Console.WriteLine("Hola.");
//         }

//         // Say hi in French
//         public static void SayHiFrench()
//         {
//             Console.WriteLine("Bonjour.");
//         }

//         // Say hi in German
//         public static void SayHiGerman()
//         {
//             Console.WriteLine("Hallo.");
//         }

//         // Say hi in Italian
//         public static void SayHiItalian()
//         {
//             Console.WriteLine("Ciao.");
//         }

//         // Say hi in Portuguese
//         public static void SayHiPortuguese()
//         {
//             Console.WriteLine("Olá.");
//         }

//         // Say hi in Russian
//         public static void SayHiRussian()
//         {
//             Console.WriteLine("Привет.");
//         }

//         // Say hi in Japanese
//         public static void SayHiJapanese()
//         {
//             Console.WriteLine("こんにちは.");
//         }

//         // Say hi in Chinese (Mandarin)
//         public static void SayHiChinese()
//         {
//             Console.WriteLine("你好.");
//         }

//         // Say hi in Arabic
//         public static void SayHiArabic()
//         {
//             Console.WriteLine("مرحباً.");
//         }
//     }
// }

// // TODO : video 114 - 02:42


// namespace Test
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             CipherApp.Play();
//         }
//     }

//     class CipherApp
//     {
//         private static bool IsPlaying { get; set; } = false;

//         private static string GetFileFromUser()
//         {
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine("Enter a file path");
//             Console.ForegroundColor = ConsoleColor.White;
//             string file = Console.ReadLine() ?? "";
//             Console.ResetColor();

//             return file;
//         }

//         private static int GetShiftFromUser()
//         {
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine("Enter the shift");
//             Console.ResetColor();
//             int shift = int.Parse(Console.ReadLine() ?? "0");

//             return shift;
//         }

//         private static void HandleEncrypt()
//         {
//             bool isValid = false;

//             while (!isValid)
//             {
//                 try
//                 {
//                     string file = GetFileFromUser();

//                     int shift = GetShiftFromUser();

//                     using StreamReader sr = new(file);

//                     string content = sr.ReadToEnd();

//                     string cipher = CaesarCipher.Encrypt(content, shift);

//                     Console.ForegroundColor = ConsoleColor.Green;
//                     Console.WriteLine(cipher);
//                     Console.ResetColor();

//                     isValid = true;
//                 }
//                 catch (Exception err)
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine(err.Message);
//                     Console.ResetColor();
//                 }
//             }
//         }

//         private static void HandleDecrypt()
//         {
//             try
//             {
//                 string file = GetFileFromUser();
//                 int shift = GetShiftFromUser();

//                 using StreamReader sr = new(file);
//                 string content = sr.ReadToEnd();

//                 string plainText = CaesarCipher.Decrypt(content, shift);

//                 Console.WriteLine(plainText);
//             }
//             catch (Exception err)
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine(err.Message);
//                 Console.ResetColor();
//             }
//         }

//         public static void Play()
//         {
//             IsPlaying = true;

//             while (IsPlaying)
//             {
//                 Console.WriteLine(
//                     "Welcome to CaesarCipherApp. let's continue ... \nE - to encrypt \nD - to decrypt \nX - to exit"
//                 );
//                 string answer = Console.ReadLine() ?? "";

//                 if (string.Equals(answer.ToLower(), "x"))
//                 {
//                     IsPlaying = false;
//                     Console.Clear();
//                     break;
//                 }

//                 if (string.Equals(answer.ToLower(), "e"))
//                 {
//                     HandleEncrypt();
//                     continue;
//                 }

//                 if (string.Equals(answer.ToLower(), "d"))
//                 {
//                     HandleDecrypt();
//                     continue;
//                 }

//                 // Wrong answer
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine($"{answer} - is not a valid answer! Please try again.");
//                 Console.ResetColor();
//             }
//         }
//     }

//     class CaesarCipher
//     {
//         public static string Encrypt(string plainText, int shift)
//         {
//             char[] plainArray = plainText.ToLower().ToCharArray();
//             char[] cipherArray = new char[plainArray.Length];
//             string cipher = "";

//             for (int i = 0; i < plainArray.Length; i++)
//             {
//                 char letter = plainArray[i];
//                 if (letter == ' ')
//                 {
//                     cipherArray[i] = letter;
//                     continue;
//                 }

//                 letter += (char)shift;

//                 if (letter > 'z')
//                 {
//                     letter -= (char)26;
//                 }
//                 else if (letter < 'a')
//                 {
//                     letter += (char)26;
//                 }
//                 cipherArray[i] = letter;
//             }

//             foreach (char c in cipherArray)
//             {
//                 cipher += c;
//             }

//             return cipher;
//         }

//         public static string Decrypt(string cipher, int shift)
//         {
//             char[] cipherArray = cipher.ToLower().ToCharArray();
//             char[] plainArray = new char[cipherArray.Length];
//             string plainText = "";

//             for (int i = 0; i < cipherArray.Length; i++)
//             {
//                 char letter = cipherArray[i];
//                 if (letter == ' ')
//                 {
//                     plainArray[i] = letter;
//                     continue;
//                 }

//                 letter -= (char)shift;

//                 if (letter > 'z')
//                 {
//                     letter -= (char)26;
//                 }
//                 else if (letter < 'a')
//                 {
//                     letter += (char)26;
//                 }
//                 plainArray[i] = letter;
//             }

//             foreach (char c in plainArray)
//             {
//                 plainText += c;
//             }

//             return plainText;
//         }
//     }
// }

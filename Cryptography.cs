// using System.Security.Cryptography;

// namespace Cryptography
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Aes key = Aes.Create();

//             string cipher = Crypto.Encrypt("Hello there", key);
//             string plainText = Crypto.Decrypt(cipher, key);

//             Console.WriteLine(cipher);
//             Console.WriteLine(plainText);
//         }
//     }

//     class Crypto
//     {
//         public static string Encrypt(string plainText, SymmetricAlgorithm key)
//         {
//             MemoryStream ms = new();
//             CryptoStream cs = new(ms, key.CreateEncryptor(), CryptoStreamMode.Write);
//             StreamWriter sw = new(cs);
//             sw.Write(plainText);
//             sw.Flush();
//             cs.FlushFinalBlock();

//             return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
//         }

//         public static string Decrypt(string cipher, SymmetricAlgorithm key)
//         {
//             MemoryStream ms = new(Convert.FromBase64String(cipher));
//             CryptoStream cs = new(ms, key.CreateDecryptor(), CryptoStreamMode.Read);
//             StreamReader sr = new(cs);

//             return sr.ReadToEnd();
//         }
//     }

//     class CaesarCipher
//     {
//         static readonly string lowerCaseAlphabet = string.Concat(
//             Enumerable.Range('a', 26).Select(c => (char)c)
//         );


//         public static string CaesarEncrypt(string plainText, int shift)
//         {
//             string cipher = "";

//             if (shift < 0)
//             {
//                 shift *= -1;
//             }

//             if (shift > lowerCaseAlphabet.Length)
//             {
//                 shift %= lowerCaseAlphabet.Length;
//             }

//             foreach (char c in plainText)
//             {
//                 bool isUpperCase = char.IsUpper(c);
//                 char lowerCased = char.ToLowerInvariant(c);

//                 if (!lowerCaseAlphabet.Contains(lowerCased))
//                 {
//                     cipher += c;
//                     continue;
//                 }

//                 int originalIndex = lowerCaseAlphabet.IndexOf(lowerCased);

//                 int newIndex = originalIndex - shift;

//                 if (newIndex < 0)
//                 {
//                     newIndex = lowerCaseAlphabet.Length + newIndex;
//                 }

//                 cipher += isUpperCase
//                     ? lowerCaseAlphabet[newIndex].ToString().ToUpper()
//                     : lowerCaseAlphabet[newIndex];
//             }

//             return cipher;
//         }

//         public static string CaesarDecrypt(string cipher, int shift)
//         {
//             if (shift < 0)
//             {
//                 shift *= -1;
//             }

//             string plainText = "";

//             if (shift > lowerCaseAlphabet.Length)
//             {
//                 shift %= lowerCaseAlphabet.Length;
//             }

//             foreach (char c in cipher)
//             {
//                 char lowerCased = char.ToLowerInvariant(c);

//                 if (!lowerCaseAlphabet.Contains(lowerCased))
//                 {
//                     plainText += c;
//                     continue;
//                 }

//                 bool isUpperCase = char.IsUpper(c);

//                 int cipherIndex = lowerCaseAlphabet.IndexOf(lowerCased);

//                 int newIndex = cipherIndex + shift;

//                 if (newIndex > lowerCaseAlphabet.Length)
//                 {
//                     newIndex -= lowerCaseAlphabet.Length;
//                 }

//                 plainText += isUpperCase
//                     ? lowerCaseAlphabet[newIndex].ToString().ToUpper()
//                     : lowerCaseAlphabet[newIndex];
//             }

//             return plainText;
//         }
//     }
// }

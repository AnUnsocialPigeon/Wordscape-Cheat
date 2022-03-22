using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Wordscape_Cheat {
    class Program {
        static void Main() {
            string[] Words = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\dictionary.txt");
            while (true) {
                Console.Write("Letters: ");
                string letters = Console.ReadLine().ToLower();
                List<string> ValidWords = new List<string>();

                foreach (string s in Words) {
                    if (s.Length < 3) continue;
                    bool got = true;
                    foreach (char c in s) {
                        if (letters.Count(f => (f == c)) < s.Count(f => (f == c))) {
                            got = false;
                            break;
                        }
                    }
                    if (got) ValidWords.Add(s);
                }


                Console.WriteLine("\n" + String.Join('\n', ValidWords.ToArray()));
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

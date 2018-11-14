using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace SpellTracker
{
    class Program
    {
        static void Main(string[] args)

        {

            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "PreparedSpells.txt"));            
            StreamReader reader = new StreamReader(@"Spells.json");
            bool keepGoing = true;

            string spellsContents = reader.ReadToEnd();
            // Parse JSON, creating an array of Spell objects
            Spell[] spell = JsonConvert.DeserializeObject<Spell[]>(spellsContents);
            Components[] component = JsonConvert.DeserializeObject<Components[]>(spellsContents);
            while (keepGoing == true)
            {
                Console.WriteLine("Type part of a spell name, such as Fireball");
                string searchSpell = Console.ReadLine();
                

                // Use LINQ to search the array for a specific spell
                Spell spells = spell.Where(s => s.name == searchSpell).FirstOrDefault();

                StringBuilder sbOut = new StringBuilder();

                foreach (Spell entry in spell)
                {
                    if ((entry.name).ToUpper().Contains(searchSpell.ToUpper()))
                    {
                        sbOut.AppendLine(entry.name);

                    }
                }
                
                try
                {
                    if (spell == null)
                    {
                        Console.WriteLine("Not found, please try one of the following:" + sbOut);
                    }
                    else if(searchSpell == "quit")
                    {
                        keepGoing = false;
                    }
                    else
                    {
                        Console.WriteLine(spells.description);
                        Console.WriteLine("Level: "+ spells.level);
                        outputFile.WriteLine(spells.description);
                        outputFile.WriteLine("Level: " + spells.level);
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Spell not found. Please try one of the following. \n" + sbOut);
                }
            }
            outputFile.Close();
            outputFile.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace INEc
{
    internal class InecDataBase
    {
        static void Main(string[] args)
        {
            string[] RegVoters = { "Success", "Yomi", "Peter", "Favour", "Mike", "lekan", "Yomi", "Joseph", "Lekan", "Victor", "Yomi", "Jeff", "Success", "Olatunde", "Bolaji", "Peter", "Great" };
            Dictionary<string, int> Database = new Dictionary<string, int>();
            foreach (var item in RegVoters)
            {
                if (Database.ContainsKey(item))
                {
                    Database[item] = Database[item] + 1;
                }
                else
                {
                    Database[item] = 1;
                }
            }
            Console.WriteLine("Names and number of times registered");
            foreach (var item in Database)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key + ":" + item.Value);
                }
            }

            // INEC SHOULD USE THE HASHSET CONCEPT TO ENSURE DUPLICATES ARE REMOVED AND ENSURE DISTINCTIVENESS.
            Console.WriteLine("\n\nThe Distinctive List");
            HashSet<string> Distinctive = RegVoters.ToHashSet();
            foreach (var item in Distinctive)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

}




//string[] Names = new string[]
//        {
//            "Yusuf Akin",
//            "Yusuf Akin",
//            "Bimbo Akin",
//            "Peter Akin",
//            "Yusuf Alli",
//        };
//        HashSet<string> hashset = new HashSet<string>(Names);
//        foreach (string name in hashset){
//        {
//        }
//        Console.WriteLine(Names);







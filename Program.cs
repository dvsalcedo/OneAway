using System;

namespace OneAway
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstSentence, SecondSentence;
            Console.WriteLine("Write the first word");
            FirstSentence = Console.ReadLine();
            Console.WriteLine("Write the second word");
            SecondSentence = Console.ReadLine();
            Console.WriteLine(OneAway(FirstSentence, SecondSentence) ? "True" : "False");
            Console.ReadLine();
        }
        

        static bool OneAway(string sentenceOne, string sentenceTwo){
            int[] NumberAppears = new int[128];
            char[] CharOne = sentenceOne.ToCharArray();
            char[] CharTwo = sentenceTwo.ToCharArray();

            if( Math.Abs(CharOne.Length - CharTwo.Length) > 2 ) {
                return false;
            }

            for(int i=0; i< CharOne.Length; i++){
                ++NumberAppears[(int)CharOne[i]];
            }

            for(int i=0; i< CharTwo.Length; i++){
                ++NumberAppears[(int)CharTwo[i]];
            }

            int count = 0;
            foreach (var Number in NumberAppears)
            {
                if(Number % 2 == 1){
                    count++;
                }
            }

            return count <= 2;
        }
    }
}

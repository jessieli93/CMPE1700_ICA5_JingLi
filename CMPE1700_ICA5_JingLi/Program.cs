using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700_ICA5_JingLi
{
    class Program
    {
        static void Main(string[] args)
        {
            card[] cards = new card[52];
            int index = 0;
            foreach (card.suits s in Enum.GetValues((typeof(card.suits))))
            {
                foreach (card.face f in Enum.GetValues((typeof(card.face))))
                {
                    cards[index].Suits = s.ToString();
                    cards[index++].faces = f.ToString();

                }
            }
            foreach (card i in cards)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    
    }
}

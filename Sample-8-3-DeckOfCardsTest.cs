using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class DeckOfCardsTest
    {
        //execute app
        static void Main()
        {
            var myDeckOfCards = new DeckOfCards();
            myDeckOfCards.Shuffle();// please Cards in random order

            //display all 52 Cards in the order in which they are dealt
            for (var i = 0; i < 52; ++i)
            {
                Console.Write($"{myDeckOfCards.DealCard(),-19}");
                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}

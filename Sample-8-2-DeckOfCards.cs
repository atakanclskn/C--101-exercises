using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Fig 8.11: DeckOfCards.Cs
    //DeckOfCardsclass represents a deck of playing cards 
    class DeckOfCards
    {
        //create one Random object to share among DeckOfCards objects
        private static Random randomNumbers = new Random();
        private const int NumberOfCards = 52; //Number of cards in a deck
        private Card[] deck = new Card[NumberOfCards];
        private int currentCard = 0; // index of nextCard to be dealt (0-51)

        //construtor fills deck of Cards
        public DeckOfCards()
        {
            string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            //populate deck wih Card objects
            for (var count = 0; count < deck.Length; ++count)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }
        //shuffle deck of Cards with one-pass alorithm
        public void Shuffle()
        {
            //after shuffling, dealing should start at deck [0] again
            currentCard = 0; // reinitialize crrentCard

            // for each Card, pick another random Card and swap them
            for (var first = 0; first < deck.Length; ++first)
            {
                //select a random number between 0 and 51 
                var second = randomNumbers.Next(NumberOfCards);
                //swap current Card wit randomly selected card
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        // deal on Card 
        public Card DealCard()
        {
            //determine whether Cards remain to be dealt
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else {
                return null; //indicate that all Cards were dealt
            }
        }
    }
}
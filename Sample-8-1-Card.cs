using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Fig. 8.10: Card.cs
    // Card class represents a playing card
    class Card
    {
        private string Face { get; } //Card's face ("Ace", "Deuce", ...) 
        private string Suit { get; } //Card's suit ("Hearts", "Diamond", ...) 

        //two-parameter constructor initializes card's Face and Suit
        public Card(string face, string suit)
        {
            Face = face;// initialize face of card 
            Suit = suit; // initialize suit of card 
        }
        //return string representation of Card 
        public override string ToString() => $"{Face} of {Suit}";
         
    }
}

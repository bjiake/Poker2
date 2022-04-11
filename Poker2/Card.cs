using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker2
{
    class Card
    {
        public enum SUIT
        { 
            Hearts,
            Spades,
            Diamonds,
            Clubs
        }
        public enum VALUE
        {
            Two = 2, Three, Four, Ffive, Six, Seven, Eight, Nine,
            Ttn, Jack, Queen, King, Ace
        }
        public SUIT MySuit { get; set; }
        public VALUE MyValue { get; set; }
    }
}

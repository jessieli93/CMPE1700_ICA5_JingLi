using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700_ICA5_JingLi
{
    struct card
    {
        public enum suits
        {
            club,
            spade,
            heart,
            diamond
        }
        public enum face
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        public string Suits;
        public string faces;
        public override string ToString()
        {
            return faces + " of " + Suits;
        }
    }
}

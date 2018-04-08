using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.Logic {//this namespace handles the shared logic of all sub-games
    internal class Code {
        private List<Colour> guesses; //the pegs that make up the code

        public Code() {} //default constructor for creation of 'incomplete' codes for the players in progress guesses



        public void addPeg(Colour col, int index) { //add a 'peg' to a specified position
            //TODO: fill this out
        }

        public void removePeg(Colour col, int index) { //remove a 'peg' from a specified position
            //TODO: fill this out
        }

        //interfaces to allow limited access to private members from public scope
        public List<Colour> Guesses { get { return guesses; } }
    }
}

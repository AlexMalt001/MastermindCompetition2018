using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.Logic {//this namespace handles the shared logic of all sub-games
    public class Code {
        private Colour?[] guesses; //the pegs that make up the code. The '?' means it is nullable (ie be 'empty')

        public Code(int codeLength) {//default constructor for creation of 'incomplete' codes for the players in progress guesses
            guesses = new Colour?[codeLength];
        }

	    public Colour?[] getGuesses() { //get the array of guesses
		    return guesses;
	    }

	    public int getCodeLength() { //get the length of this code
		    return guesses.Length;
	    }

        public void addPeg(Colour col, int index) { //add a 'peg' to a specified position
	        guesses[index] = col;
        }

        public void removePeg(Colour col, int index) { //remove a 'peg' from a specified position
	        guesses[index] = null;
        }

        //interfaces to allow limited access to private members from public scope
        public Colour?[] Guesses { get { return guesses; } }

	    public GuessResult checkGuess(Code comparison) {
		    if (getCodeLength() != comparison.getCodeLength()) //if the codes are of different lengths
				throw new Exception("Mismatch in code lengths");

			GuessResult result = new GuessResult(0,0); //the result that will be generated and then returned

		    Dictionary<Colour?, int> thisColourCounts = new Dictionary<Colour?, int>(); //holds the counts of each colour for this code
			Dictionary<Colour?, int> compareColourCounts = new Dictionary<Colour?, int>(); //holds the counts of each colour for the comparison code
		    foreach (Colour col in Enum.GetValues(typeof(Colour))) { //add a space for each colour in the dictionary
			    thisColourCounts.Add(col,0);
				compareColourCounts.Add(col,0);
		    }

			foreach(Colour? col in getGuesses()) { //initialise the dictionary for this
				thisColourCounts[col]++; //increment the appropriate dictionary space
			}
		    foreach (Colour? col in comparison.getGuesses()) { //initalise the dictionary for the comparison code
			    compareColourCounts[col]++; //increment the appropriate dictionary space
		    }

		    foreach (KeyValuePair<Colour?, int> colPair in thisColourCounts) { //for each colour in the dictionary
				result.setRightColours(result.getRightColours() + 
				                       Math.Min(colPair.Value, compareColourCounts[colPair.Key])); 
									   //increment the number of successes by the number of shared colours

		    }

		    for (int i = 0; i < getCodeLength(); i++) { //for each peg in a code
				if(guesses[i] == comparison.getGuesses()[i]) //if the peg is the same in the same position for the 2 codes
					result.setRightPlaces(result.getRightPlaces()+1); //increment the number of right places
		    }


		    return result;
	    }
    }
}

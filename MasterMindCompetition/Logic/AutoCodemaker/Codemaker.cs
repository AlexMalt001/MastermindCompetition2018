using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.Logic.AutoCodemaker { //contains code for specifically the auto-codemaker sub game
	internal class Codemaker {
		public Code generateCode(int codeLength) { //generate a new code to be guessed by the player
			Random rng = new Random(); //create a random number generator (RNG)
			Code returnThis = new Code(codeLength); //placeholder for the code to be generated
			for (int i = 0; i < codeLength; i++) {
				//for each position in the array
				returnThis.addPeg((Colour)rng.Next(0, Enum.GetValues(typeof(Colour)).Length), i);
				/*EXPLAINATION OF THE ABOVE LINE
                 * adds a peg of a random colour to position i
                 * to get a random colour:
                 *      it finds a random between 0 and
                 *      the total number of possible colours. This is found by:
                 *          Enum.GetValues(typeof(Colour)).Length
                 *          Enum.GetValues(typeof(Colour)) returns a list of all possible colours
                 *          Array.Length returns the length of this array
			     *      this returns an integer, which must be cast to a colour via (Colour)
                 */
			}
			return returnThis;
		}
	}
}

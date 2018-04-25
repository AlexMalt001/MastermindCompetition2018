using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.Logic {
	public class GuessResult { //holds the result of a guess
		private int rightPlaces = 0; //holds the number of pegs in the right place
		private int rightColours = 0; //holds the number of pegs of the right colour (including those in the right place)

		public GuessResult(int _rightPlaces, int _rightColours) { //constructor
			rightPlaces = _rightPlaces; //set to the incoming value
			rightColours = _rightColours; //set to the incoming value
		}

		public void setRightPlaces(int _rightPlaces) { //set the number of pegs in the right place
			rightPlaces = _rightPlaces; //set to the incoming value
		}

		public void setRightColours(int _rightColours) { //set the number of pegs of the right colour (including those in the right place)
			rightColours = _rightColours; //set to the incoming value
		}

		public int getRightPlaces() { //external access to this variable
			return rightPlaces; //output the number of pegs in the right place
		}

		public int getRightColours() { //external access to this variable
			return rightColours; //output the number of pegs of the right colour (including those in the right place)
		}
	}
}

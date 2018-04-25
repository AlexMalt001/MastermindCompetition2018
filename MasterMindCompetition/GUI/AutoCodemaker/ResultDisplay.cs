using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMindCompetition.Logic;
using MasterMindCompetition.Properties;

namespace MasterMindCompetition.GUI.AutoCodemaker {
	public partial class ResultDisplay : UserControl {

		public ResultDisplay() {
			InitializeComponent();
		}

		public void displayResults(int rightColours, int rightPlaces) {

			//WHITE PEGS
			if (rightColours == 4) { //if there are four successes
				resultPegFour.Visible = true; //the fourth peg is visible
				resultPegFour.Image = Resources.whiteResultPeg; //and has a white peg
			} else {
				resultPegFour.Visible = false; //there are less than {codeLength} pegs
			}
			if (rightColours >= 3) { //if there are three or more successes
				resultPegThree.Visible = true; //the third peg is visible
				resultPegThree.Image = Resources.whiteResultPeg; //and has a white peg
			} else {
				resultPegThree.Visible = false; //there are less than 3 pegs
			}
			if (rightColours >= 2) { //if there are two or more successes
				resultPegTwo.Visible = true; //the second peg is visible
				resultPegTwo.Image = Resources.whiteResultPeg; //and has a white peg
			} else {
				resultPegTwo.Visible = false; //there are less than 2 pegs
			}
			if (rightColours >= 1) { //if there are one or more successes
				resultPegOne.Visible = true; //the first peg is visible
				resultPegOne.Image = Resources.whiteResultPeg; //and has a white peg

				//BLACK PEGS
				if (rightPlaces == 4)  //if there are four successes
					resultPegFour.Image = Resources.blackResultPeg; //black peg overwrites white peg
				if (rightPlaces >= 3)  //if there are three or more successes
					resultPegThree.Image = Resources.blackResultPeg; //black peg overwrites white peg
				if (rightPlaces >= 2)  //if there are two or more successes
					resultPegTwo.Image = Resources.blackResultPeg; //black peg overwrites white peg
				if (rightPlaces >= 1)  //if there are one or more successes
					resultPegOne.Image = Resources.blackResultPeg; //black peg overwrites white peg	

			} else {
				resultPegOne.Visible = false; //there are no pegs
			}


		}
	}
}

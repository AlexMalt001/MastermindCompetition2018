using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMindCompetition.Logic;
using MasterMindCompetition.Properties;

namespace MasterMindCompetition.GUI {
	public partial class CodeRow : UserControl {
		private bool active = true; //whether or not the control is 'active'(can be changed by user)
		private int codeLength;
		private List<Peg> pegs = new List<Peg>();
		


		public CodeRow(int _codeLength) {
			InitializeComponent();
			codeLength = _codeLength;
			for (int i = 0; i<codeLength; i++) {
				pegs.Add(new Peg(i));
				pegs[i].Location = new Point(40 * i, 0);
				pegs[i].Parent = this;
				pegs[i].onClick += onPegClick;
			}
			foreach (Peg peg in pegs)
				peg.Colour = Colour.Red; //the default colour is red
		}

		private void onPegClick(Peg sender, int index) {//when the peg tells the row its been clicked
			onClick?.Invoke(this, index); //the row says its been clicked
		}

		public delegate void PegClickHandler(CodeRow sender, int pegNumber);
		public event PegClickHandler onClick;//triggered when a peg is clicked (likely to change it. this is handled in the main form)


		public Code getCode() { //get the whole code represented by the CodeRow
			Code c = new Code(codeLength); //make a new code
			for (int i = 0; i < codeLength; i++) //for each peg
				c.addPeg(pegs[i].Colour, i); //add the peg to the code
			return c;
		}

		public void setCode(Code c) { //set the code displayed on the row
			for (int i = 0; i < c.getCodeLength(); i++) { //for each peg in the code
				setPegColour(i, (Colour)c.getGuesses()[i]); //update the peg's display
			}
		}

		public Colour getPegColour(int peg) { //get the colour of a certain peg
			return pegs[peg].Colour;
		}

		

		public void setPegColour(int pegIndex, Colour colour) { //set a peg's colour
			pegs[pegIndex].Colour = colour;
		}

		public void displayResults(GuessResult result) {

			//WHITE PEGS
			if (result.getRightColours() == codeLength) { //if there are four successes
				resultPegFour.Visible = true; //the fourth peg is visible
				resultPegFour.Image = Resources.whiteResultPeg; //and has a white peg
			} else {
				resultPegFour.Visible = false; //there are less than {codeLength} pegs
			}
			if (result.getRightColours() >= 3) { //if there are three or more successes
				resultPegThree.Visible = true; //the third peg is visible
				resultPegThree.Image = Resources.whiteResultPeg; //and has a white peg
			} else {
				resultPegThree.Visible = false; //there are less than 3 pegs
			}
			if (result.getRightColours() >= 2) { //if there are two or more successes
				resultPegTwo.Visible = true; //the second peg is visible
				resultPegTwo.Image = Resources.whiteResultPeg; //and has a white peg
			} else {
				resultPegTwo.Visible = false; //there are less than 2 pegs
			}
			if (result.getRightColours() >= 1) { //if there are one or more successes
				resultPegOne.Visible = true; //the first peg is visible
				resultPegOne.Image = Resources.whiteResultPeg; //and has a white peg

				//BLACK PEGS
				if (result.getRightPlaces() == 4)  //if there are four successes
					resultPegFour.Image = Resources.blackResultPeg; //black peg overwrites white peg
				if (result.getRightPlaces() >= 3)  //if there are three or more successes
					resultPegThree.Image = Resources.blackResultPeg; //black peg overwrites white peg
				if (result.getRightPlaces() >= 2)  //if there are two or more successes
					resultPegTwo.Image = Resources.blackResultPeg; //black peg overwrites white peg
				if (result.getRightPlaces() >= 1)  //if there are one or more successes
					resultPegOne.Image = Resources.blackResultPeg; //black peg overwrites white peg	

			} else {
				resultPegOne.Visible = false; //there are no pegs
			}


		}

		[Description("Can the code be changed?"), Category("Data")]
		public bool Active {
			get { return active; }
			set { active = value; }
		}

	}
}

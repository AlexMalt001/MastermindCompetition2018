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
		private Colour[] pegColours = new Colour[4];
		private bool active = true; //whether or not the control is 'active'(can be changed by user)
		


		public CodeRow() {
			InitializeComponent();
			for (int i = 0; i < pegColours.Length; i++) //for each peg space
				pegColours[i] = Colour.Red; //the default colour is red
		}

		private void pegTwo_Click(object sender, EventArgs e) { //when the second peg is clicked
			onClick?.Invoke(this, 1); //its a null propogation operator. basically it only runs it if onclick != null
		}

		private void pegThree_Click(object sender, EventArgs e) { //when the third peg is clicked
			onClick?.Invoke(this, 2); //its a null propogation operator. basically it only runs it if onclick != null
		}

		private void pegFour_Click(object sender, EventArgs e) { //when the fourth peg is clicked
			onClick?.Invoke(this, 3); //its a null propogation operator. basically it only runs it if onclick != null
		}

		private void pegOne_Click(object sender, EventArgs e) { //when the first peg is clicked
			onClick?.Invoke(this, 0); //its a null propogation operator. basically it only runs it if onclick != null
			
		}

		public delegate void pegClickHandler(CodeRow sender, int pegNumber);
		public event pegClickHandler onClick;//triggered when a peg is clicked (likely to change it. this is handled in the main form)


		public Code getCode() { //get the whole code represented by the CodeRow
			Code c = new Code(4); //this is hardcoded and therefore bad. TODO:fix
			c.addPeg(pegColours[0], 0); //setup the first peg
			c.addPeg(pegColours[1], 1); //setup the second peg
			c.addPeg(pegColours[2], 2); //setup the third peg
			c.addPeg(pegColours[3], 3); //setup the fourth peg
			return c;
		}

		public void setCode(Code c) { //set the code displayed on the row
			for (int i = 0; i < c.getCodeLength(); i++) { //for each peg in the code
				setPegColour(i, (Colour)c.getGuesses()[i]); //update the peg's display
			}
		}

		public Colour getPegColour(int peg) { //get the colour of a certain peg
			return pegColours[peg];
		}

		private Bitmap getImageForColour(Colour c) { //get the image relating to each colour
			switch (c) {
				case Colour.Green:
					return Resources.greenPeg;
				case Colour.Red:
					return Resources.redPeg;
				case Colour.Blue:
					return Resources.bluePeg;
				case Colour.Orange:
					return Resources.orangePeg;
				case Colour.Yellow:
					return Resources.yellowPeg;
				case Colour.Pink:
					return Resources.pinkPeg;
				default:
					throw (new Exception("I have no idea how this happened")); //this should never be thrown
			}
		}

		public void setPegColour(int pegIndex, Colour colour) { //set a peg's colour
			pegColours[pegIndex] = colour; //update the representation of the gui
			switch (pegIndex) { //update the gui
				case 0:
					pegOne.Image = getImageForColour(colour);
					break;
				case 1:
					pegTwo.Image = getImageForColour(colour);
					break;
				case 2:
					pegThree.Image = getImageForColour(colour);
					break;
				case 3:
					pegFour.Image = getImageForColour(colour);
					break;
				default: //if they try to set a peg outside the range
					throw (new IndexOutOfRangeException("there are only 4 pegs currently"));
			}
		}

		public void displayResults(GuessResult result) {

			//WHITE PEGS
			if (result.getRightColours() == 4) { //if there are four successes
				resultPegFour.Visible = true; //the fourth peg is visible
				resultPegFour.Image = Resources.whiteResultPeg; //and has a white peg
			} else {
				resultPegFour.Visible = false; //there are less than 4 pegs
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

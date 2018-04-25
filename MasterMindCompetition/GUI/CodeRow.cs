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
using MasterMindCompetition.GUI.AutoCodemaker;
using MasterMindCompetition.Logic;
using MasterMindCompetition.Properties;

namespace MasterMindCompetition.GUI {
	public partial class CodeRow : UserControl {
		private bool active = true; //whether or not the control is 'active'(can be changed by user)
		private int codeLength;
		private List<Peg> pegs = new List<Peg>();
		private List<ResultDisplay> resultDisplays = new List<ResultDisplay>();
		


		public CodeRow(int _codeLength) {
			InitializeComponent();
			codeLength = _codeLength;
			for (int i = 0; i<codeLength; i++) {
				pegs.Add(new Peg(i));
				pegs[i].Location = new Point(40 * i, 0);
				pegs[i].Parent = this;
				pegs[i].onClick += onPegClick;
			}
			for (int i = 0; i < (int)Math.Ceiling((double)codeLength / 4); i++) {
				resultDisplays.Add(new ResultDisplay());
				resultDisplays[i].Location = new Point(40 * (codeLength + i), 0);
				resultDisplays[i].Parent = this;
			}

			Size = new Size(40 * codeLength + 40 * (int)Math.Ceiling((double) codeLength / 4), 40);
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

		public static int keepAboveZero(int value) { //constrain a value between 2
			return (value > 0) ? value : 0;
		}

		public void displayResults(GuessResult res) {
			int i = 0;
			for (; i < Math.Floor((double) res.getRightColours() / 4); i++) {
				resultDisplays[i].displayResults(4, keepAboveZero(res.getRightPlaces()-i*4));
			}

			if (res.getRightColours() % 4 != 0) {
				resultDisplays[i].displayResults(res.getRightColours()%4, keepAboveZero(res.getRightPlaces()-i*4));
			}
		}

		

		[Description("Can the code be changed?"), Category("Data")]
		public bool Active {
			get { return active; }
			set { active = value; }
		}

	}
}

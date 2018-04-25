using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MasterMindCompetition.GUI.PVP {
	public partial class PVPMenu : Form {
		public PVPMenu() { //CONSTRUCTOR
			InitializeComponent();
			ControlBox = false; //hide the exit buttons
		}

		
		public int maxGuesses = 0; //values to be taken in later - needed for outside access
		public int codeLength = 0;

		private void startButton_Click(object sender, EventArgs e) {
			maxGuesses = (int)maxGuessesBox.Value; //take in a value from the input boxes
			codeLength = (int) codeLengthBox.Value; 
			DialogResult  = DialogResult.OK; //the user has successfully provided input
			Close(); //close the form
		}
	}
}

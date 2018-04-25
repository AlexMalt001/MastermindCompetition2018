using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMindCompetition.Logic;

namespace MasterMindCompetition.GUI.PVP {
	
	public partial class CodemakerEntry : Form {
		private CodeRow codeRow; //the code row the codemaker uses
		public CodemakerEntry(int codeLength) { //allows the codemaker to enter a code
			InitializeComponent();
			rowContainer.AutoScroll = true; //allow the user to scroll if their code length is too wide for the window
			ControlBox = false; //hide exit buttons
			codeRow = new CodeRow(codeLength); //create a new coderow...
			rowContainer.Controls.Add(codeRow); //and add it to the container
			codeRow.Location = new Point(0,0); //set its location
			codeRow.onClick += pegClickHandler; //and subscribe to its click event
		}

		public Code getCode() { //external access to internal member
			return codeRow.getCode(); //return the code
		}

		private void pegClickHandler(CodeRow sender, int pegNumber, bool leftClick) { //called when an active peg is clicked to be changed
			if (leftClick)
				sender.setPegColour(pegNumber,
					(Colour)((int)(sender.getPegColour(pegNumber) + 1) %
					         Enum.GetValues(typeof(Colour)).Length)); //set to the next colour in the enum
			else {
				int length = Enum.GetValues(typeof(Colour)).Length; //number of members of the enum
				int value = (int)(sender.getPegColour(pegNumber) - 1) %
				            length; //take one off and mod to ensure get within allowed range
				value = value < 0 ? value + length : value; //c# mod is weird and gives -ve nos. this prevents that
				sender.setPegColour(pegNumber, (Colour)value); //set to the previous colour in the enum
			}

		}

		private void submitButton_Click(object sender, EventArgs e) { //when the submit button is pressed
			DialogResult = DialogResult.OK;
			Close(); //close the form
		}
	}
}

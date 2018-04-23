using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMindCompetition.Logic;
using MasterMindCompetition.Logic.AutoCodemaker;

namespace MasterMindCompetition.GUI {
    public partial class MasterMindForm : Form, IAutoCodemakerHostForm { //this must allows the display of all codemaker functions, hence the interface
	    private CodeRow currentCodeRow;
	    private AutoCodemakerGame game;
	    private bool newCode = false;
	    private int currentCodeRows = 0;

        public MasterMindForm() {
            InitializeComponent();
	       
        }

	    public void nextTurn() { //called at the beginning of each turn
			CodeRow newCodeRow = new CodeRow { //create a new code row control
				Active = true };
			newCodeRow.onClick += pegClickHandler;//subscribe to the event 
		    currentCodeRow = newCodeRow;
		    containerPanel.Controls.Add(newCodeRow);
		    newCodeRow.Left = 0;
		    newCodeRow.Top = 40*currentCodeRows;
		    currentCodeRows++;
	    }

	    public void displayResults(GuessResult result) {
			currentCodeRow.displayResults(result);
	    }

	    public Code getCodeFromPlayer() { //returns this turn's code
		    while (!newCode) {
			    Application.DoEvents();
		    }

		    newCode = false;
			return currentCodeRow.getCode();
	    }

	    public void endPlayerInput() { //stops the player from being able to input
		    currentCodeRow.onClick -= pegClickHandler;
	    }

	    public void endGame(bool winLose) { //called when the player wins or loses
		    throw new NotImplementedException();
	    }

	    public void pegClickHandler(CodeRow sender, int pegNumber) { //called when an active peg is clicked to be changed
		    sender.setPegColour(pegNumber, (Colour)((int)(sender.getPegColour(pegNumber)+1) % Enum.GetValues(typeof(Colour)).Length)); //set to the next colour in the enum
		    
	    }

		private void button1_Click(object sender, EventArgs e) {
			game = new AutoCodemakerGame(this);
			game.runGame(3,4);

		}

		private void button2_Click(object sender, EventArgs e) {
			newCode = true;
		}
	}
}

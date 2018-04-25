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

namespace MasterMindCompetition.GUI {
    public abstract partial class MastermindForm : Form, IMastermindHostForm { //this must allows the display of all codemaker functions, hence the interface


	    protected CodeRow currentCodeRow; //the latest row being worked on
	    protected MastermindGame game; //the game logic object
	    protected bool newCode = false; //whether a new code is avaliable yet
	    protected bool closing = false; //is the form closing
	    protected int currentCodeRows = 0; //the number of guesses so far
	    protected int maxTurns, codeLength; //the number of turns the player is allowed and the length of a code

        protected MastermindForm(int _maxTurns, int _codeLength) { //CONSTRUCTOR
	        maxTurns = _maxTurns; //take in the max number of turns needed to win
	        codeLength = _codeLength; //take in the code length TODO:IMPLEMENT THIS PROPERLY
            InitializeComponent();
	       
        }

	    public virtual void nextTurn() { //called at the beginning of each turn
			CodeRow newCodeRow = new CodeRow (codeLength) { //create a new code row control
				Active = true };
		    currentCodeRow = newCodeRow; //update the global variable
		    containerPanel.Controls.Add(newCodeRow); //add the new row to the container
		    containerPanel.VerticalScroll.Value = containerPanel.VerticalScroll.Minimum; //scroll to the top. This fixes a weird drawing issue
		    containerPanel.HorizontalScroll.Value = containerPanel.HorizontalScroll.Minimum; //scroll to the far left. this also fixes a weird drawing issue
		    newCodeRow.Left = 0; //align the row to the left of the container
		    newCodeRow.Top = 40*currentCodeRows; //place the row in the correct vertical position
		    currentCodeRows++; //there is one more row
		    containerPanel.ScrollControlIntoView(newCodeRow); //scroll the current row into view
	    }

	    public void displayResults(GuessResult result) { //display the results(black and white pins
			currentCodeRow.displayResults(result); //display results on current row
	    }

	    


	    public virtual void endGame(bool winLose) { //called when the player wins or loses
		    MessageBox.Show("You won in just " + game.getCurrentGuesses() + " Guesses!"); //show a cool win message
		    Application.Exit(); //close the program
	    }

	    protected abstract void startButton_Click(object sender, EventArgs e); 

		private void MasterMindForm_FormClosing(object sender, FormClosingEventArgs e) {
			Close(); //close the form
			closing = true; //tell it to quit the input wait loop and finish all logic

		}

		protected void submitButton_Click(object sender, EventArgs e) {
			newCode = true; //there is now a new code avaliable
		}
    }
}

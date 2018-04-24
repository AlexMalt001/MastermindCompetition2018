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

namespace MasterMindCompetition.GUI.AutoCodemaker {
    public partial class MasterMindForm : Form, IAutoCodemakerHostForm { //this must allows the display of all codemaker functions, hence the interface


	    private CodeRow currentCodeRow; //the latest row being worked on
	    private AutoCodemakerGame game; //the game logic object
	    private bool newCode = false; //whether a new code is avaliable yet
	    private bool closing = false; //is the form closing
	    private int currentCodeRows = 0; //the number of guesses so far
	    private int maxTurns, codeLength; //the number of turns the player is allowed and the length of a code

        public MasterMindForm(int _maxTurns, int _codeLength) { //CONSTRUCTOR
	        maxTurns = _maxTurns; //take in the max number of turns needed to win
	        codeLength = _codeLength; //take in the code length TODO:IMPLEMENT THIS PROPERLY
            InitializeComponent();
	       
        }

	    public void nextTurn() { //called at the beginning of each turn
			CodeRow newCodeRow = new CodeRow { //create a new code row control
				Active = true };
			newCodeRow.onClick += pegClickHandler;//subscribe to the event 
		    currentCodeRow = newCodeRow; //update the global variable
		    containerPanel.Controls.Add(newCodeRow); //add the new row to the container
		    containerPanel.VerticalScroll.Value = containerPanel.VerticalScroll.Minimum; //scroll to the top. This fixes a wierd drawing issue
		    newCodeRow.Left = 0; //align the row to the left of the container
		    newCodeRow.Top = 40*currentCodeRows; //place the row in the correct vertical position
		    currentCodeRows++; //there is one more row
		    containerPanel.ScrollControlIntoView(newCodeRow); //scroll the current row into view
	    }

	    public void displayResults(GuessResult result) { //display the results(black and white pins
			currentCodeRow.displayResults(result); //display results on current row
	    }

	    public Code getCodeFromPlayer() { //returns this turn's code
		    while (!newCode && !closing) { //while there isnt a new code avaliable yet
			    Application.DoEvents(); //keep the GUI refreshing
		    }

		    if (closing) { //if the form is about to close
			    return null; //this causes the game logic to unceremoniously end itself ;(
		    }

		    newCode = false; //reset this var
			return currentCodeRow.getCode(); //return the value
	    }

	    public void endPlayerInput() { //stops the player from being able to input
		    currentCodeRow.onClick -= pegClickHandler; //stop listening to clicks on old rows
	    }

	    public void endGame(bool winLose) { //called when the player wins or loses
		    MessageBox.Show("You won in just " + game.getCurrentGuesses() + " Guesses!"); //show a cool win message
		    Application.Exit(); //close the program
	    }

	    public void pegClickHandler(CodeRow sender, int pegNumber) { //called when an active peg is clicked to be changed
		    sender.setPegColour(pegNumber, (Colour)((int)(sender.getPegColour(pegNumber)+1) % Enum.GetValues(typeof(Colour)).Length)); //set to the next colour in the enum
		    
	    }

		private void startButton_Click(object sender, EventArgs e) {
			game = new AutoCodemakerGame(this); //make a new game
			game.runGame(maxTurns,codeLength); //run the game with appropriate params

		}

		private void MasterMindForm_FormClosing(object sender, FormClosingEventArgs e) {
			Close(); //close the form
			closing = true; //tell it to quit the input wait loop and finish all logic

		}

		private void submitButton_Click(object sender, EventArgs e) {
			newCode = true; //there is now a new code avaliable
		}
    }
}

﻿using System;
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
using MasterMindCompetition.Logic.PVP;

namespace MasterMindCompetition.GUI.PVP {
    public partial class PVPForm : MastermindForm, IPVPHostForm { //this must allows the display of all codemaker functions, hence the interface


	    
	    private new PVPGame game; //the game logic object
	    

        public PVPForm(int _maxTurns, int _codeLength) : base(_maxTurns,_codeLength){ //CONSTRUCTOR
            InitializeComponent();
	       
        }

	    public override void nextTurn() { //called at the beginning of each turn
		    base.nextTurn();
			currentCodeRow.onClick += pegClickHandler;//subscribe to the event 
	    }

	    public Code getCodeFromCodemaker() { //get the codemaker to make a new code
		    MessageBox.Show("The Codemaker must now enter a code, dont let the codebreaker look!"); //warn the players to not let the codebreaker see the code
		    CodemakerEntry ce = new CodemakerEntry(codeLength); //create a new code entry form
		    ce.ShowDialog(); //and show it as a dialog
		    return ce.getCode(); //then return the code that was entered in it
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

	    public override void endGame(bool winLose) { //called when the player wins or loses
		    MessageBox.Show("You won in just " + game.getCurrentGuesses() + " Guesses!"); //show a cool win message
		    Close(); //close the program
	    }

	    private void pegClickHandler(CodeRow sender, int pegNumber, bool leftClick) { //called when an active peg is clicked to be changed
		    if (leftClick)
			    sender.setPegColour(pegNumber,
				    (Colour) ((int) (sender.getPegColour(pegNumber) + 1) %
				              Enum.GetValues(typeof(Colour)).Length)); //set to the next colour in the enum
		    else {
			    int length = Enum.GetValues(typeof(Colour)).Length; //number of members of the enum
				int value = (int)(sender.getPegColour(pegNumber) - 1) %
				            length; //take one off and mod to ensure get within allowed range
			    value = value < 0 ? value + length: value; //c# mod is weird and gives -ve nos. this prevents that
			    sender.setPegColour(pegNumber,(Colour)value); //set to the previous colour in the enum
			}
			    
	    }

		protected override void startButton_Click(object sender, EventArgs e) {
			game = new PVPGame(this); //make a new game
			base.game = game; //give the base class the new game as well
			game.runGame(maxTurns,codeLength); //run the game with appropriate params

		}
    }
}

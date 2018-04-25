using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.Logic.PVP {//contains code for specifically the PVP sub game
    internal class PVPGame : MastermindGame { //specifically the game where seperate human players act as codemaker and codebreaker

	    protected new IPVPHostForm hostForm;
        public PVPGame(IPVPHostForm _hostForm) : base(_hostForm){ //create (but do not start) a new game
	        hostForm = _hostForm; //take in a reference to the host form
	        //TODO: fill this out
        }

        protected override void initialiseGame() { //run first stages of game (generating target code, etc)
	        target = hostForm.getCodeFromPlayer();//ask the codemaker for a new code
        }

	    protected override bool doTurn() { //run through one turn
		    hostForm.nextTurn(); //prepare the GUI


			Code inputCode = hostForm.getCodeFromPlayer(); //get a new guess from the player
		    if (inputCode == null) //this occurs if the form wants to close
			    return false; //just stop the loop
			hostForm.endPlayerInput(); //tell the form to stop recieving player input
			guessCodes.Add(inputCode); //add the guess to the list of guesses
		    GuessResult result = inputCode.checkGuess(target); //generate the results
		    if (result.getRightPlaces() == inputCode.getCodeLength()) { //if the code is corrent
			    hostForm.endGame(true); //end the game with a win
			    return false; //stop the game loop
		    }
			hostForm.displayResults(result); //display the results of the game on the form

		    return true; //the player has not guessed the code yet; more turns need to be done
	    }

	    protected override void endGame(bool winLose) { //end the game
		    hostForm.endGame(winLose); //tell the form to end the game
	    }

    }
}

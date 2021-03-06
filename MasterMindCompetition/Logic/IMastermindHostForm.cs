﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.Logic { //this namespace handles the shared logic of all sub-games
    public interface IMastermindHostForm { //this allows the logic components to have no awareness of the GUI components
        //requirements will be added here as they become necessary

	    void nextTurn(); //start the next turn
	    void endGame(bool winLose); //end the game
	    void displayResults(GuessResult result); //display the calculated results in the GUI
    }
}

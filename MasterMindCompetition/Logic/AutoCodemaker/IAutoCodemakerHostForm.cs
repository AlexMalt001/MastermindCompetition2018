﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.Logic.AutoCodemaker {
	interface IAutoCodemakerHostForm : IMastermindHostForm {
		
		Code getCodeFromPlayer(); //get the player to make a new guess
		void endPlayerInput(); //stop the player's input for this turn
	}
}

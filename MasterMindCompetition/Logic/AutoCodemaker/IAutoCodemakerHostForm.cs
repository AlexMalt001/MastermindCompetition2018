using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.Logic.AutoCodemaker {
	interface IAutoCodemakerHostForm : ICodemakerHostForm {
		Code getCodeFromPlayer();
		void endPlayerInput();
		void endGame(bool winLose);
	}
}

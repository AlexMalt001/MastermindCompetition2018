using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.Logic.AutoCodemaker {
    internal class AutoCodemakerGame : MastermindGame {
        public AutoCodemakerGame(ICodemakerHostForm hostForm) : base(hostForm) {
            //TODO: fill this out
        }

        public override void newGame(int _maxGuesses) {
            base.newGame(_maxGuesses); //run the code required by all MM games (from the base class)
            //TODO: fill this out
        }
    }
}

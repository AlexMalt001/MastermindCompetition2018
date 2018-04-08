using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.Logic.AutoCodemaker {//contains code for specifically the auto-codemaker sub game
    internal class AutoCodemakerGame : MastermindGame { //specifically the game where the computer acts as the codemaker and a human player acts as codebreaker
        private Codemaker codemaker = new Codemaker(); //create a new codemaker
        public AutoCodemakerGame(ICodemakerHostForm hostForm) : base(hostForm) { //create (but do not start) a new game
            //TODO: fill this out
        }

        protected override void initialiseGame() { //run first stages of game (generating target code, etc)
            target = codemaker.generateCode(codeLength);
        }
    }
}

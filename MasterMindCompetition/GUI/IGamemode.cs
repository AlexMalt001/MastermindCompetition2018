using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.GUI {
	interface IGamemode { //a gamemode. TODO: make this an abstract class. I have no idea what i was thinking
		void runGamemode(); //need to be able to run the gamemode
		string Name { get; } //this is to be displayed in the combobox. doesnt need to ever be set
	}
}

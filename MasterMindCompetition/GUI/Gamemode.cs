using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.GUI {
	abstract class Gamemode { //a gamemode. TODO: make this an abstract class. I have no idea what i was thinking
		public abstract void runGamemode(); //need to be able to run the gamemode
		public abstract string Name { get; } //this is to be displayed in the combobox. doesnt need to ever be set
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMindCompetition.GUI.AutoCodemaker {
	class AutoCodemakerGamemode : Gamemode {
		public override void runGamemode() { //run the gamemode
			AutoCodemakerMenu menu = new AutoCodemakerMenu(); //create a new menu form
			menu.ShowDialog(); //show the form to the user
			DialogResult result = menu.DialogResult; //check the form was completed successfully
			if (result == DialogResult.OK) { //if it was...


				AutoCodemakerForm form = new AutoCodemakerForm(menu.maxGuesses, menu.codeLength); //make a new game form...
				form.ShowDialog(); //and display it.
			} 
			
		}

		public override string Name { //required to look good on the combobox
			get { return "Auto Codemaker"; }
		}
	}
}

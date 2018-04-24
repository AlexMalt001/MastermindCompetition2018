using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMindCompetition.GUI {
	class AutoCodemakerGamemode : IGamemode {
		public void runGamemode() {
			AutoCodemakerMenu menu = new AutoCodemakerMenu();
			menu.ShowDialog();
			DialogResult result = menu.DialogResult;
			if (result == DialogResult.OK) {


				MasterMindForm form = new MasterMindForm(menu.maxGuesses, menu.codeLength);
				form.ShowDialog();
			} 
			
		}

		public string Name {
			get { return "Auto Codemaker"; }
		}
	}
}

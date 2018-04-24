using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMindCompetition.GUI.AutoCodemaker;

namespace MasterMindCompetition.GUI {

	

	public partial class MainMenuForm : Form {
		static readonly List<IGamemode> gamemodes = new List<IGamemode>{new AutoCodemakerGamemode()};
		public MainMenuForm() { //CONSTRUCTOR
			InitializeComponent();
			gamemodeComboBox.DataSource = gamemodes; //set the combobox to look at the list of all gamemodes
			gamemodeComboBox.ValueMember = "Name"; //show the user the name of each gamemode
		}


		private void startButton_Click(object sender, EventArgs e) { //when the user hits go
			Visible = false;//hide the main menu
			((IGamemode) gamemodeComboBox.SelectedItem).runGamemode(); //run the selected gamemode
			//the above line halts this sequence until the user quits the gamemode
			Visible = true;//bring the main menu back
		}

		private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e) { //when the 'X' button is pressed
				Application.Exit(); //close the whole application (normally this would just close the form and leave a blank application running in the background - no es bueno
			
		}
	}
}

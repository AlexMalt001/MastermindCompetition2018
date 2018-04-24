using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMindCompetition.GUI {

	

	public partial class MainMenuForm : Form {
		static readonly List<IGamemode> gamemodes = new List<IGamemode>{new AutoCodemakerGamemode()};
		public MainMenuForm() {
			InitializeComponent();
			gamemodeComboBox.DataSource = gamemodes;
			gamemodeComboBox.ValueMember = "Name";
		}

		private bool closed = false;

		private void startButton_Click(object sender, EventArgs e) {
			Visible = false;
			((IGamemode) gamemodeComboBox.SelectedItem).runGamemode();
			Visible = true;
		}

		private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e) {
				Application.Exit();
			
		}
	}
}

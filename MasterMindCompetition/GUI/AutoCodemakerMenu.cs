using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MasterMindCompetition.GUI {
	public partial class AutoCodemakerMenu : Form {
		public AutoCodemakerMenu() {
			InitializeComponent();
			ControlBox = false;
		}

		
		public int maxGuesses = 0;
		public int codeLength = 0;

		private void startButton_Click(object sender, EventArgs e) {
			maxGuesses = (int)maxGuessesBox.Value;
			codeLength = (int) codeLengthBox.Value;
			DialogResult  = DialogResult.OK;
			Close();
		}
	}
}

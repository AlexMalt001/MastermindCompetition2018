using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMindCompetition.GUI; //allows use of the GUI components 

namespace MasterMindCompetition {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
	        new GUI.MainMenuForm().Show(); //show a main menu form. doing it this way means the whole program wont quit when the form quits
			Application.Run(); //start the message loop, etc
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtakuEyes {
    public partial class Form1:Form {
		private int easterEgg = 0;

		public Form1() {
            InitializeComponent();
            pn_TopWin.BackColor = Color.FromArgb(125, Color.Black);
		}

		//TOP BAR -------------------------------------

		//IMPORT DLL
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		//MOVE WINDOW
		private void pn_TopWin_MouseDown(object sender, MouseEventArgs e) {
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

        private void closeButton_Click(object sender, EventArgs e) {
			Application.Exit();
        }

        private void miniButton_Click(object sender, EventArgs e) {
			this.WindowState = FormWindowState.Minimized;
        }

        private void logo_Click(object sender, EventArgs e) {

			easterEgg++;

			if(easterEgg > 10) {
				raph.Visible = true;
			}
			if(easterEgg > 20) {
				chocolat.Visible = true;
				vanilla.Visible = true;
			}
			if(easterEgg > 50) {
				zeroTwo.Visible = true;
			}
		}

        private void search_Enter(object sender, EventArgs e) {
			search.Text = "";
		}

        private void searchButton_Click(object sender, EventArgs e) {
			error.Visible = false;
			messageError.Text = "";
			if (search.Text != "" && search.Text != "Enter something !") {

				loading.Visible = true;

				for(int i =0;i < 100;i++) {
					loading.Increment(i);
                }

				if (search.Text.Length >= 3) {
					Scraper scrap = new Scraper(search.Text);
					if(!scrap.search()) {
						error.Visible = true;
						messageError.Text = "Error 404 !\nNo site contains your anime\nTry with another name";
					}
				}
                else {
					error.Visible = true;
					messageError.Text = "Error 404 !\nNo site contains your anime\nTry with another name";
				}
				loading.Visible = false;


			}
			else {
				search.Text = "Enter something !";
            }


		}
    }
}

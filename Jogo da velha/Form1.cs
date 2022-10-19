using Jogo_da_velha.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Game : Form
    {

        public static Game instance;
        public Game()
        {
            instance = this;
            InitializeComponent();

            Settings.Default.Save();

            LblXw.Text = Settings.Default.X_Pointo.ToString();
            LblBw.Text = Settings.Default.O_Pointo.ToString();
        }

        public bool space1, space2, space3, space4, space5, space6, space7, space8, space9 = false;
        public bool ps1, ps2, ps3, ps4, ps5, ps6, ps7, ps8, ps9 = true;

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Main.Controls.Clear();
            GameM tic = new GameM() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Main.Controls.Add(tic);
            tic.Show();
        }

        private int total = 9;

        public bool player_x, player_o = false;

        public string[] matriz = new string[9];

        public bool win = false;

        public string mimic;

        public void close_main()
        {
            this.Close();
        }

        public void Restart()
        {
            this.Main.Controls.Clear();
            GameM tic = new GameM() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Main.Controls.Add(tic);
            tic.Show();
        }


        public void UpdatePoints(int pointo, string vencedor)
        {
            if (vencedor == "X")
            {
                Game.instance.LblXw.Text = pointo.ToString();
            } else if (vencedor == "O")
            {
                Game.instance.LblBw.Text = pointo.ToString();
            }
        }


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }


    }
}

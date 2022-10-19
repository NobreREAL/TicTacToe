using Jogo_da_velha.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class GameM : Form
    {
        public static GameM instance;
        public GameM()
        {
            instance = this;
            InitializeComponent();
        }

        public bool space1, space2, space3, space4, space5, space6, space7, space8, space9 = false;
        public bool ps1, ps2, ps3, ps4, ps5, ps6, ps7, ps8, ps9 = true;



        private int total = 9;

        public bool player_x, player_o = false;

        private void t1_Tick(object sender, EventArgs e)
        {
            empate(total, GameM.instance.win);
        }

        private void empate(int contagem, bool win)
        {
            if (contagem == 0 && !win)
            {
                t1.Enabled = false;
                Drawn Alert_Drawn = new Drawn();

                Alert_Drawn.Show();
            }
            else if (contagem == 0 && win)
            {
                t1.Enabled = false;
            }
        }

        private void Btn1_Click_1(object sender, EventArgs e)
        {
            ConfJogador(player_x, player_o);
            ConfJogada(player_x, player_o, space1, Btn1, 0);
            GameM.instance.total -= 1;
        }

        private void Btn2_Click_1(object sender, EventArgs e)
        {
            ConfJogador(player_x, player_o);
            ConfJogada(player_x, player_o, space2, Btn2, 1);
            GameM.instance.total -= 1;
        }

        private void Btn3_Click_1(object sender, EventArgs e)
        {
            ConfJogador(player_x, player_o);
            ConfJogada(player_x, player_o, space3, Btn3, 2);
            GameM.instance.total -= 1;
        }

        private void Btn4_Click_1(object sender, EventArgs e)
        {
            ConfJogador(player_x, player_o);
            ConfJogada(player_x, player_o, space3, Btn4, 3);
            GameM.instance.total -= 1;
        }

        private void Btn5_Click_1(object sender, EventArgs e)
        {
            ConfJogador(player_x, player_o);
            ConfJogada(player_x, player_o, space3, Btn5, 4);
            GameM.instance.total -= 1;
        }

        private void Btn6_Click_1(object sender, EventArgs e)
        {
            ConfJogador(player_x, player_o);
            ConfJogada(player_x, player_o, space3, Btn6, 5);
            GameM.instance.total -= 1;
        }

        private void Btn7_Click_1(object sender, EventArgs e)
        {
            ConfJogador(player_x, player_o);
            ConfJogada(player_x, player_o, space3, Btn7, 6);
            GameM.instance.total -= 1;
        }
        private void Btn8_Click_1(object sender, EventArgs e)
        {
            ConfJogador(player_x, player_o);
            ConfJogada(player_x, player_o, space3, Btn8, 7);
            GameM.instance.total -= 1;
        }        

        private void Btn9_Click_1(object sender, EventArgs e)
        {
            ConfJogador(player_x, player_o);
            ConfJogada(player_x, player_o, space3, Btn9, 8);
            GameM.instance.total -= 1;
        }

        public string[] matriz = new string[9];

        public bool win = false;

        public string mimic;

        private static void GetPointo(string vencedor)
        {

            if (vencedor == "X")
            {
                int pointo = Settings.Default.X_Pointo;
                pointo += 1;


                Settings.Default["X_Pointo"] = pointo;
                Settings.Default.Save();

                Game.instance.UpdatePoints(pointo, vencedor);
            }
            else if (vencedor == "O")
            {
                int pointo = Settings.Default.O_Pointo;
                pointo += 1;


                Settings.Default["O_Pointo"] = pointo;
                Settings.Default.Save();

                Game.instance.UpdatePoints(pointo, vencedor);
            }
        }

        static void verificar(int t, string turn)
        {

            GameM.instance.mimic = turn;

            if (GameM.instance.total > 0)
            {



                if (GameM.instance.matriz[0] == turn && GameM.instance.matriz[1] == turn && GameM.instance.matriz[2] == turn)
                {
                    Win alert_win = new Win();

                    GetPointo(turn);
                    alert_win.Show();

                    GameM.instance.win = true;



                }

                if (GameM.instance.matriz[0] == turn && GameM.instance.matriz[3] == turn && GameM.instance.matriz[6] == turn)
                {
                    Win alert_win = new Win();

                    GetPointo(turn);
                    alert_win.Show();

                    GameM.instance.win = true;
                }

                if (GameM.instance.matriz[0] == turn && GameM.instance.matriz[4] == turn && GameM.instance.matriz[8] == turn)
                {
                    Win alert_win = new Win();

                    GetPointo(turn);
                    alert_win.Show();

                    GameM.instance.win = true;
                }

                if (GameM.instance.matriz[3] == turn && GameM.instance.matriz[4] == turn && GameM.instance.matriz[5] == turn)
                {
                    Win alert_win = new Win();

                    GetPointo(turn);
                    alert_win.Show();

                    GameM.instance.win = true;

                }

                if (GameM.instance.matriz[6] == turn && GameM.instance.matriz[7] == turn && GameM.instance.matriz[8] == turn)
                {
                    Win alert_win = new Win();

                    GetPointo(turn);
                    alert_win.Show();

                    GameM.instance.win = true;
                }

                if (GameM.instance.matriz[1] == turn && GameM.instance.matriz[4] == turn && GameM.instance.matriz[7] == turn)
                {
                    Win alert_win = new Win();

                    GetPointo(turn);
                    alert_win.Show();

                    GameM.instance.win = true;

                }

                if (GameM.instance.matriz[2] == turn && GameM.instance.matriz[4] == turn && GameM.instance.matriz[6] == turn)
                {
                    Win alert_win = new Win();

                    GetPointo(turn);
                    alert_win.Show();

                    GameM.instance.win = true;

                }

                if (GameM.instance.total == 0 && !GameM.instance.win)
                {
                    MessageBox.Show("Empate!");
                    return;
                }

            }
        }

        private static void ConfJogada(bool player_x, bool player_o, bool space, PictureBox Picture, int pos)
        {


            if (player_x && !player_o && Picture.Image == null)
            {
                Picture.Image = Properties.Resources.cross;
                space = true;

                GameM.instance.matriz[pos] = "X";

                verificar(GameM.instance.total, "X");

            }
            else if (!player_x && player_o && Picture.Image == null)
            {
                Picture.Image = Properties.Resources.circle;
                space = true;

                GameM.instance.matriz[pos] = "O";

                verificar(GameM.instance.total, "O");

            }
            else
            {
                return;
            }
        }

        private static void ConfJogador(bool player_x, bool player_o)
        {
            if (!player_x && !player_o)
            {
                GameM.instance.player_x = true;
            }
            else if (player_x && !player_o)
            {
                GameM.instance.player_x = false;
                GameM.instance.player_o = true;

            }
            else if (!player_x && player_o)
            {
                GameM.instance.player_o = false;
                GameM.instance.player_x = true;
            }
            else
            {
                GameM.instance.player_o = false;
                GameM.instance.player_x = true;
            }
        }

       
    }
}

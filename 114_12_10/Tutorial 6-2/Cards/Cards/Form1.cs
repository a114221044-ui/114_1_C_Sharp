using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                showSelectedCard(cardListBox.SelectedItems.ToString());
            }
            else
            {
                MessageBox.Show("請先選擇一張卡牌。");
            }
        }

        private void showSelectedCard(string cardName)
        {


            switch (cardName)
            {
                case "黑陶Ace":
                    ShowAceSpades();
                    break;
                case "紅心10   ":
                    ShowTenHearts();
                    break;
                case "梅花King":
                    ShowKingClubs();
                    break;
                default:
                    MessageBox.Show("未知的卡牌選擇。", "錯誤");
                    break;
            }

        }

        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;

        }
        private void ShowTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }
        private void ShowKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

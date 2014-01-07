using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IT151BubbleSortWin
{
    public partial class Form1 : Form
    {
        Boolean mbPause = false;
        const Int32 MAX = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void DoWork()
        {
            Int32 iXCoordinate = 6, iYCoordinate = 6;

            for (Int32 j = 0; j < 12; j++)
            {
                for (Int32 i = 0; i < 12; i++)
                {
                    var CurrPoint = new Point(iXCoordinate, iYCoordinate);
                    lblTiles[j, i] = new Label();
                    lblTiles[j, i].Location = CurrPoint;
                    lblTiles[j, i].BackColor = Color.White;
                    lblTiles[j, i].BorderStyle = BorderStyle.FixedSingle;
                    lblTiles[j, i].Size = new Size(35, 35);
                    iXCoordinate += 34;
                    this.Controls.Add(lblTiles[j, i]);
                }
                iXCoordinate = 6;
                iYCoordinate += 34;
            }

            this.Refresh();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DoWork();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (mbPause)
            {
                mbPause = false;
                btnPause.Text = "Pause";
            }
            else
            {
                    mbPause = true;
                    btnPause.Text = "Un-Pause";
            }
        }
    }
}

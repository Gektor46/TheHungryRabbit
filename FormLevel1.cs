using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHungryRabbit
{
    abstract partial class FormLevel1 : Form
    {
        int carrot; //морковка
        public FormLevel1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.PlayNyam();

            carrot = 3;
            labelCarrot1.Visible = true;
            labelCarrot2.Visible = true;
            labelCarrot3.Visible = true;
        }

        private void FinishGame()
        {
            Sound.PlayWeeping();
            DialogResult DR = MessageBox.Show("Кролик остался голодным, попробывать ещё раз?", "Сообщение",
                MessageBoxButtons.YesNo);
            if (DR == System.Windows.Forms.DialogResult.Yes)
                StartGame();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;


        }

        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            StartGame();
        }

        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            if (carrot ==0)
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            FinishGame();
        }

        private void labelCarrot1_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            Sound.PlayCrunch();
            carrot--;
        }
    }
}

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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartLevel1();
        }

        private void BoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxSound.Checked)
            {
                Sound.SoundOn();
                BoxSound.Text = "Звук есть";
                Sound.PlayCrunch();
            }
            else
            {
                Sound.SoundOff();
                BoxSound.Text = "Звука нет";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartLevel1()
        {
            FormLevel1 Level1 = new FormLevel1();
            DialogResult DR = Level1.ShowDialog();
            if (DR == System.Windows.Forms.DialogResult.OK)
                StartLevel2();
        }

        private void StartLevel2()
        {
            Sound.PlayUra();
            FormLevel2 Level2 = new FormLevel2();
            DialogResult DR = Level2.ShowDialog();
            if (DR == System.Windows.Forms.DialogResult.OK)
                StartLevel3();
        }

        private void StartLevel3()
        {
            FormLevel3 Level3 = new FormLevel3();
            DialogResult DR = Level3.ShowDialog();
            if (DR == System.Windows.Forms.DialogResult.OK)
                StartLevel3();
        }
    }
}

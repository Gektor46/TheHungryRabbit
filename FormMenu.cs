/***************************************************************************************
* Project name  : TheHungryRabbit2                                                     *
* Project type  : win64 console app                                                    *
* File_name     : TheHungryRabbit2                                                     *
* Language      : c#. MSVS 2017 and above                                              *
* Programmers   : Razenkov A. A.                                                       *
* Modified      : -                                                                    *
* Created       : 25.03.19                                                             *
* Last Revision : 30.05.19                                                             *
* Comment       : FormMenu                                                             *
***************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHungryRabbit2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        //Кнопка старта игры
        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartLevel1();
        }
        //Подключение музыки
        private void boxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSound.Checked)
            {
                Sound.SoundOn();
                boxSound.Text = "Звук есть";
                Sound.PlayCrunch();
            }
            else
            {
                Sound.SoundOff();
                boxSound.Text = "Звука нет";
            }
        }
        //Выход
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
                StartLevel4();
        }
        
        private void StartLevel4()
        {
            FormLevel4 Level4 = new FormLevel4();
            DialogResult DR = Level4.ShowDialog();
            if (DR == System.Windows.Forms.DialogResult.OK)
                StartLevel5();
        }

        private void StartLevel5()
        {
            FormLevel4 Level5 = new FormLevel5();
            DialogResult DR = Level5.ShowDialog();
            if (DR == System.Windows.Forms.DialogResult.OK)
            {
                StartYouWin();
            }
        }
        //Игра пройдена
        private void StartYouWin()
        {
            Sound.PlayUra();
            MessageBox.Show("Кролик больше не голоден!", "Поздравляем");
        }
    }
}


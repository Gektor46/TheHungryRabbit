/***************************************************************************************
* Project name  : TheHungryRabbit2                                                     *
* Project type  : win64 console app                                                    *
* File_name     : TheHungryRabbit2                                                     *
* Language      : c#. MSVS 2017 and above                                              *
* Programmers   : Razenkov A. A.                                                       *
* Modified      : -                                                                    *
* Created       : 25.03.19                                                             *
* Last Revision : 30.05.19                                                             *
* Comment       : FormLevel                                                            *
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
    public partial class FormLevel : Form
    {
        public int carrot = 3;// морковка

        public FormLevel()
        {
            InitializeComponent();
        }
        //Начало игры
        public void StartGame()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.PlayNyam();      
        }
        //Конец игры с возможностью начать заново или выйти
        public void FinishGame()
        {
            Sound.PlayWeeping();
            DialogResult DR = MessageBox.Show("Кролик остался голодным, попробывать ещё раз?", "Сообщение",
                MessageBoxButtons.YesNo);
            if (DR == System.Windows.Forms.DialogResult.Yes)
                StartGame();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            //Видимость морковки
            labelCarrot1.Visible = true;
            labelCarrot2.Visible = true;
            labelCarrot3.Visible = true;
            if (carrot == 2)
                labelCarrot3.Visible = false;
        }
        //Начать завново
        public void FormLevel_Shown(object sender, EventArgs e)
        {
            StartGame();
        }
        //Затронули границы формы
        public void label1_MouseEnter(object sender, EventArgs e)
        {
            carrot = 3;
            FinishGame();
        }
        //Финиш, когда собрали всю морковку
        public void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            if (carrot == 0)
                DialogResult = System.Windows.Forms.DialogResult.OK;

        }
        //Скушали морковку
        public void labelCarrot1_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            Sound.PlayCrunch();
            carrot--;
        }
    }
}

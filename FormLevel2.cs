/***************************************************************************************
* Project name  : TheHungryRabbit2                                                     *
* Project type  : win64 console app                                                    *
* File_name     : TheHungryRabbit2                                                     *
* Language      : c#. MSVS 2017 and above                                              *
* Programmers   : Razenkov A. A.                                                       *
* Modified      : -                                                                    *
* Created       : 25.03.19                                                             *
* Last Revision : 30.05.19                                                             *
* Comment       : FormLevel2                                                           *
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
    public partial class FormLevel2 : FormLevel
    {
        private void VisibleObject()
        {
            //Новая морковка
            carrot = 5;
            labelCarrot4.Visible = true;
            labelCarrot5.Visible = true;
        }

        public FormLevel2()
        {
            InitializeComponent();
            VisibleObject();
        }
        //Затронули лабиринт
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            VisibleObject();
            FinishGame();
        }
        //Скушали новую морковку
        private void labelCarrot4_MouseEnter_1(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            Sound.PlayCrunch();
            carrot--;
        }
        //Затронули границы(с новой морковкой)
        private void label1_MouseEnter_1(object sender, EventArgs e)
        {
            VisibleObject();
        }
    }
}

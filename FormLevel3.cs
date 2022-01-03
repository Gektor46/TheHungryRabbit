/***************************************************************************************
* Project name  : TheHungryRabbit2                                                     *
* Project type  : win64 console app                                                    *
* File_name     : TheHungryRabbit2                                                     *
* Language      : c#. MSVS 2017 and above                                              *
* Programmers   : Razenkov A. A.                                                       *
* Modified      : -                                                                    *
* Created       : 25.03.19                                                             *
* Last Revision : 30.05.19                                                             *
* Comment       : FormLevel3                                                           *
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
    public partial class FormLevel3 : FormLevel
    {
        public FormLevel3()
        {
            //убрали 1 морковку
            carrot = 2;
            labelCarrot3.Visible = false;
            InitializeComponent();
        }
        //Затронули лабиринт
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            carrot = 2;
            FinishGame();
        }
        //Затронули границы(с новой морковкой)
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            carrot = 2;
            labelCarrot3.Visible = false;
        }
    }
}

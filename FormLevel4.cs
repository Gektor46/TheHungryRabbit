/***************************************************************************************
* Project name  : TheHungryRabbit2                                                     *
* Project type  : win64 console app                                                    *
* File_name     : TheHungryRabbit2                                                     *
* Language      : c#. MSVS 2017 and above                                              *
* Programmers   : Razenkov A. A.                                                       *
* Modified      : -                                                                    *
* Created       : 25.03.19                                                             *
* Last Revision : 30.05.19                                                             *
* Comment       : FormLevel4                                                           *
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
    public partial class FormLevel4 : FormLevel1
    {
        private void VisibleObject()
        {
            carrot = 3;
            labelKey.Visible = true;
            labelCastle1.Visible = true;
            labelCastle2.Visible = true;
            labelCastle3.Visible = true;
        }

        public FormLevel4()
        {
            InitializeComponent();
        }
        //Взяли ключ
        protected void labelKey_MouseEnter(object sender, EventArgs e)
        {
            labelKey.Visible = false;
        }
        //Затронули новые части лабиринта
        protected void label13_MouseEnter(object sender, EventArgs e)
        {
            VisibleObject();
            FinishGame();
        }
        //Затронули старые части лабиринта
        protected void label8_MouseEnter(object sender, EventArgs e)
        {
            VisibleObject();
        }
        //Затронули замок
        protected void labelCastle1_MouseEnter(object sender, EventArgs e)
        {
            if (labelKey.Visible)
            {
                carrot = 3;
                FinishGame();
            }
            else
            {
                ((Label)sender).Visible = false;
                Sound.PlayOpening();
            }
        }
    }
}

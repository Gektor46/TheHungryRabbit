/***************************************************************************************
* Project name  : TheHungryRabbit2                                                     *
* Project type  : win64 console app                                                    *
* File_name     : TheHungryRabbit2                                                     *
* Language      : c#. MSVS 2017 and above                                              *
* Programmers   : Razenkov A. A.                                                       *
* Modified      : -                                                                    *
* Created       : 25.03.19                                                             *
* Last Revision : 12.06.19                                                             *
* Comment       : FormLevel5                                                          *
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
    public partial class FormLevel5 : FormLevel4
    {
        public FormLevel5()
        {
            InitializeComponent();
            label8.Visible = false;
            label6.Visible = false;
            label10.Visible = false;
        }
        //Чередование видимости объетов
        private void Timer_Tick(object sender, EventArgs e)
        {
            label16.Visible = !label16.Visible;
            label8.Visible = !label8.Visible;

            label15.Visible = !label15.Visible;

            label7.Visible = !label7.Visible;
            label6.Visible = !label6.Visible;

            label5.Visible = !label5.Visible;
            label10.Visible = !label10.Visible;
        }
    }
}

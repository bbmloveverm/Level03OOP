﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level03OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder stroutput = new StringBuilder("");

            //human Tom = new human();

            //Tom.Age = 200;
            //stroutput.AppendLine("Tom_age =" + Tom.Age);

            //human Tom = new human();
            //stroutput.AppendLine("Tom_age = "+ Tom.Age );
            //Tom.Age = 10;
            //stroutput.AppendLine("Tom_age = "+Tom.Age);

            //Tom.IncreateAge();
            //stroutput.AppendLine("Tom_age = " + Tom.Age);

            //int i = 0;
            //while (i < 5)
            //{
            //    Tom.IncreateAge();
            //    stroutput.AppendLine("Tom_age = " + Tom.Age);
            //    i++;
            //}

            // human Tom = new human();
            /* String Stringoutput = "";
             Tom.Dorun();
             Stringoutput = Tom.Dorun();
             stroutput.AppendLine(Stringoutput);*/
            //stroutput.AppendLine(Tom.Dorun());

            //Tom.Age = 15;
            //stroutput.AppendLine("Tom Age = "+ Tom.Age);
            //Tom.IncreateAge();
            //stroutput.AppendLine("Tom Age = " + Tom.Age);

            //Tom.IncreateAge(10); Overload ส่งค่า Int
            //stroutput.AppendLine("Tom Age = " + Tom.Age);

            /* Overload human
            human Tom = new human(20);
            stroutput.AppendLine("Tom Age = " + Tom.Age);
            */

            human Tom = new human(30);
            human Le = new human(45);

            stroutput.AppendLine("Tom Age = "+Tom.Age);
            stroutput.AppendLine("Le Age = "+Le.Age);

            loutput.Text= stroutput.ToString();


        }
    }

}

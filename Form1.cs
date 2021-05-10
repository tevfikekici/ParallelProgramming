using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Parallel.Invoke(
                () =>
                {

                },
                () =>
                {
                    counter1();
                },
                () =>
                {
                    counter2();
                }

                );
        }

        private void counter1()
        {
            for (int i = 0; i <= 30; i++)
            {
                Thread.Sleep(300);
                label1.Text = i + " ";
            }
        }

        private void counter2()
        {
            for (int i = 0; i <= 30; i++)
            {
                Thread.Sleep(100);
                label2.Text = i + " ";
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_1
{
    public partial class Form1 : Form
    {

        static public int n;

        public double[] t = new double[n + 1];

        public Form1()
        {
            InitializeComponent();
        }

        public void startCalc()
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }

    static class sistemMethods
    {
        static public string display()
        {

            return "ku";
        }
    }

    class sistemMethodsStatic
    {
        public string display()
        {
            sistemMethods.display();
            return "ku";
        }
    }
}

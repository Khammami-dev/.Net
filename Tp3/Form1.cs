using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (
               int i = 0; i < lst2.SelectedItems.Count; i = i++)

            {

                lst1.Items.Remove(lst2.SelectedItems[i]);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(textBox1.Text.ToString());
            if (lst1.Items.Count != 0)
            {
                btnToutEffacer1.Enabled = true;
            }
            if (lst2.Items.Count != 0)
            {
                btnToutEffacer2.Enabled = true;
            }

        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst1.Items.Count != 0)
            {
                btnEffacer1.Enabled = true;
                btnChangeLst2.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnAjouter.Enabled = true;
        }

        private void lst2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst2.Items.Count != 0)
            {
                btnEffacer2.Enabled = true;
                btnChangeLst1.Enabled = true;
               
                
            }
        }

        private void btnEffacer1_Click(object sender, EventArgs e)
        {
            for (
                int i = 0; i < lst1.SelectedItems.Count; i = i++)

             {

                lst1.Items.Remove(lst1.SelectedItems[i]);

             }
        }

        private void btnToutEffacer1_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
        }

        private void btnToutEffacer2_Click(object sender, EventArgs e)
        {
            lst2.Items.Clear();
        }

        private void btnChangeLst2_Click(object sender, EventArgs e)
        {

            lst2.Items.Add(lst1.SelectedItem);
            lst1.Items.Remove(lst1.SelectedItem);
            
            if (lst2.Items.Count != 0)
            {
                btnToutEffacer2.Enabled = true;
            }
        }

        private void btnChangeLst1_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(lst2.SelectedItem);
            lst2.Items.Remove(lst2.SelectedItem);
            if (lst2.Items.Count != 0)
            {
                btnToutEffacer2.Enabled = true;
            }
        }
    }
}

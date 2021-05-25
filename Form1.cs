using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friends
{
    public partial class Form1 : Form
    {
        List<string> myFriends = new List<string>();
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myFriends;
        }

        //New Friend Button Control
        private void btn_nwFrnd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_nwFrnd.Text))
            {
                MessageBox.Show("TextBox is empty!");
            }
            else
            {
                myFriends.Add(txtbox_nwFrnd.Text);
                listBox1.DataSource = bs;
                bs.ResetBindings(false);
                txtbox_nwFrnd.Clear();
                txtbox_nwFrnd.Focus();
                label1.Text = "There are " + myFriends.Count + " person(s) in the list";
            }
           
        }
        //When Enter Key is in Focus, and Pressed
        private void btn_nwFrnd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_nwFrnd.PerformClick();
            }
        }

        private void btn_bstFrnds_Click(object sender, EventArgs e)
        {
            myFriends.Add("Daniel Ahmed");
            myFriends.Add("Blessing Nwaoguimo");
            myFriends.Add("Abednego Okegwu");
            myFriends.Add("Maria Sesebo");
            myFriends.Add("Hillary Odinchefu");
            myFriends.Add("Cyril Ikelie");
            myFriends.Add("Mario Francis");
            myFriends.Add("Alex Conley");
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            txtbox_nwFrnd.Focus();
            label1.Text = "There are " + myFriends.Count + " person(s) in the list";
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            bs.ResetBindings(false);
        }

        private void btn_reverse_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            myFriends.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            bs.Clear();
            label1.Text = "";
            bs.ResetBindings(false);
        }
    }
}

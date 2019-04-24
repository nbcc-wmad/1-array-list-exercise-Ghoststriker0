using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        private ArrayList words = new ArrayList();
        bool isReversed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            words.Add("I ");
            words.Add("love ");
            words.Add("programming ");
            words.Add("so ");
            words.Add("much ");
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            if (isReversed == true)
            {
                words.Reverse();
                isReversed = false;
            }

            ShowMessage();
        }   

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (isReversed == false)
            {
                words.Reverse();
                isReversed = true;
            }

            ShowMessage();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isReversed == false)
            {
                if(words.Count >= 6)
                {
                    words.RemoveAt(1);
                }

                words.Insert(1, txtSecondPos.Text + " ");
                ShowMessage();
            }

            else
            {
                MessageBox.Show("Make sure the sentence is not reversed");
            }
        }

        private void btnRemoveSecondPos_Click(object sender, EventArgs e)
        {
            if (isReversed == false)
            {
                if(words.Count > 5)
                {
                    words.RemoveAt(1);
                }
                
                else
                {
                    MessageBox.Show("You can't delete the original message");
                }

                ShowMessage();
            }

            else
            {
                MessageBox.Show("Make sure the sentence is not reversed");
            }
        }

        private void ShowMessage()
        {
            string message = "";

            foreach (string word in words)
            {
                message += word;
            }

            lblMessage.Text = message;
        }
    }
}

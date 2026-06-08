using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParkingLotSystemModule1
{
    public partial class Start : Form
    {

        Form1 mainForm;

        public Start()
        {
            InitializeComponent();

            mainForm = new Form1();

            // Let Form1 know which Start instance created it so Form1 can return to it
            mainForm.startForm = this;

            // Ensure a single shared Form3 instance is used to avoid resetting state
            mainForm.slotManager = Form3.GetInstance(mainForm);

        }

        // Allow creating Start with existing Form1 so we don't recreate Form1 when returning
        public Start(Form1 existingMain)
        {
            InitializeComponent();
            mainForm = existingMain;
            mainForm.startForm = this;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_try1_Click(object sender, EventArgs e)
        {
            // Open main system (Form1)
            mainForm.Show();
            this.Hide();
        }

        private void btn_try2_Click(object sender, EventArgs e)
        {
           Application.Exit(); // Exit the application
        }

        private void btn_try3_Click(object sender, EventArgs e)
        {
            // Open slot manager (Form3)
            // IMPORTANT: do NOT create another Form1 her

            if (mainForm.slotManager == null || mainForm.slotManager.IsDisposed)
            {
                mainForm.slotManager = Form3.GetInstance(mainForm);  // reuse shared instance
            }

            var mgr = Form3.GetInstance(mainForm);
            mgr.Show();
            mgr.BringToFront();
            this.Hide();
        }


        private void Start_Load(object sender, EventArgs e)
        {
            // labas Form3 
            if (mainForm.slotManager == null || mainForm.slotManager.IsDisposed)
            {
                mainForm.slotManager = Form3.GetInstance(mainForm);
                mainForm.slotManager.Show();
                mainForm.slotManager.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParkingLotSystemModule1
{
    public partial class Form2 : Form
    {
        Form1 mainForm; // access to Form1's data and methods
        int currentRowIndex = -1;
        ParkingSlot parkingSlot; //acces laman ng parkingslot

        public Form2(Form1 form, ParkingSlot Ps)
        {
            InitializeComponent();
            mainForm = form; // access Form1's data and methods
            parkingSlot = Ps; // access ParkingSlot's methods
        }
        private int FindVehicle(string plate)
        {
            foreach (DataGridViewRow row in mainForm.dataGridView1.Rows) // loop through Form1's DataGridView rows
            {
                if (row.IsNewRow) continue;

                if (row.Cells[0].Value.ToString() == plate &&
                     row.Cells[4].Value.ToString() == "Active")
                {
                    return row.Index;
                }
            }
            return -1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string plate = tb_plateNumber.Text; 

            if (plate == "") //pag wala laman = error message
            {
                MessageBox.Show("Please enter plate number!");
                return;
            }

            int rowIndex = FindVehicle(plate);

            if (rowIndex == -1)
            {
                MessageBox.Show("Vehicle not found or already exited!");
                return;
            }

            currentRowIndex = rowIndex;


            lbl_timeIn.Text = mainForm.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();

            MessageBox.Show("Vehicle Found!");

            if (currentRowIndex == -1)
            {
                MessageBox.Show("Please search vehicle first!");
                return;
            }

            DataGridViewRow row = mainForm.dataGridView1.Rows[currentRowIndex]; // get time in row cell 3
            DateTime timeIn = (DateTime)row.Cells[3].Value;
            DateTime timeOut = DateTime.Now;

            double hours = (timeOut - timeIn).TotalHours; //hours compute

            if (hours <= 0) // pag time out is less than time in, set hours to 0.01 to avoid negative or zero hours
                hours = 0.01;

            lbl_hoursStayed.Text = hours.ToString("0.00");


            double rate = 20;


            string type = row.Cells[2].Value.ToString();

            double baseFee = 0;
            double additionalRate = 0;

            // Set rates based on vehicle type
            if (type == "Motorcycle")
            {
                baseFee = 20;      // First 2 hours
                additionalRate = 10; // Every succeeding hour
            }
            else if (type == "Car")
            {
                baseFee = 50;
                additionalRate = 25;
            }
            else if (type == "Van and Pickup Trucksd")
            {
                baseFee = 65;
                additionalRate = 35;
            }
            else // Buses and Trucks
            {
                baseFee = 100;
                additionalRate = 50;
            }

            double total;

            // First 2 hours fixed rate
            if (hours <= 2)
            {
                total = baseFee;
            }
            else
            {
                total = baseFee + ((hours - 2) * additionalRate);
            }

            lbl_totalFee.Text = "₱ " + total.ToString("0.00");

            double minutes = (timeOut - timeIn).TotalMinutes; //pantest
 
        }


        public void btn_exitVehicle_Click(object sender, EventArgs e)
        {

            if (currentRowIndex == -1)
            {
                MessageBox.Show("Please search vehicle first!");
                return;
            }

            DataGridViewRow row = mainForm.dataGridView1.Rows[currentRowIndex];

            // check if already exited para di mag repeat
            if (row.Cells[4].Value.ToString() == "Exited")
            {
                MessageBox.Show("Vehicle already exited!");

                return;
            }

            // Change Row Color for the exited row (use the found index) and set status
            row.DefaultCellStyle.BackColor = Color.Red;
            row.Cells[4].Value = "Exited";




            // get slot num
            string slot = row.Cells[5].Value.ToString();
            string slotNum = slot;

            // enable slot in slotmanager
            if (mainForm.slotManager != null && !mainForm.slotManager.IsDisposed)
            {
                mainForm.slotManager.UpdateSlotStatus(slotNum, "Vacant");
            }

            
            if (parkingSlot != null && !parkingSlot.IsDisposed)
            {
                parkingSlot.EnableSlot(slot);
            }

            mainForm.dataGridView1.Rows.RemoveAt(currentRowIndex);

            mainForm.UpdateParkingInfo();

            MessageBox.Show("Vehicle Successfully Exited!");
            this.Close();
            Start startForm = new Start(mainForm);

        }



        private void lbl_timeIn_Click(object sender, EventArgs e)
        {

        }

        private void lbl_hoursStayed_Click(object sender, EventArgs e)
        {

        }

        private void lbl_totalFee_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

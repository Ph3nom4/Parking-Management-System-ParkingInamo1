
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ParkingLotSystemModule1
{



    public partial class Form3 : Form
    {

        int maxSlots = 10;

        public Form1 mainForm;

        public static Form3 Instance; // para di umulit yung form 1 instance lang   

        public Form3(Form1 form)
        {
            InitializeComponent();
            mainForm = form;

            string[] slots =
             {
               "A1","A2","A3","A4","A5",
               "B1","B2","B3","B4","B5"
             };

            foreach (string s in slots)
            {
                DVG_Slot.Rows.Add(s, "Car", "Vacant");
            }

            UpdateAvailableSlots();

            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // Allow clicking anywhere on a row to select it and populate fields
            this.DVG_Slot.CellClick += new DataGridViewCellEventHandler(this.DVG_Slot_CellClick);

        }

        private void UpdateAvailableSlots()
        {
            int parkedVehicles = 0;
            int occupiedSlots = 0;

            // COUNT OCCUPIED SLOTS (Form3 grid)
            foreach (DataGridViewRow row in DVG_Slot.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells[2].Value != null &&
                    row.Cells[2].Value.ToString() == "Occupied")
                {
                    occupiedSlots++;
                    parkedVehicles++;
                }
            }

            // AVAILABLE SLOTS
            int available = maxSlots - occupiedSlots;

            // 🚗 COUNT PARKED VEHICLES (Form1 grid)
      

          

            // update label
            lblAvailable.Text = available.ToString();
            lbl_occupiedSlot.Text = occupiedSlots.ToString();
            lbl_parkedVehicle.Text = parkedVehicles.ToString();


        }


        public static Form3 GetInstance(Form1 form)
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new Form3(form);
            }

            return Instance;
        }





        private void DVG_Slot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Keep existing handler if wired in designer; forward to common logic
            DVG_Slot_PopulateFromRow(e.RowIndex);
        }

        private void DVG_Slot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate fields when user clicks anywhere on the row
            DVG_Slot_PopulateFromRow(e.RowIndex);
        }

        private void DVG_Slot_PopulateFromRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < DVG_Slot.Rows.Count)
            {
                var row = DVG_Slot.Rows[rowIndex];
                txt_slotnum.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                cmb_slottype.SelectedItem = row.Cells[1].Value?.ToString();
                cmb_status.SelectedItem = row.Cells[2].Value?.ToString();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmb_slottype.Items.Add("Car"); // manual add
            cmb_slottype.Items.Add("Motorcycle");
            cmb_slottype.Items.Add("Van and Pickup Trucks");
            cmb_slottype.Items.Add("Truck and Buses");
            cmb_status.Items.Add("Vacant");
            cmb_status.Items.Add("Occupied");

            cmb_slottype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status.DropDownStyle = ComboBoxStyle.DropDownList;

            DVG_Slot.AllowUserToAddRows = false;
            DVG_Slot.MultiSelect = false;
            DVG_Slot.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            // NOW SYNC FROM FORM1
            foreach (DataGridViewRow row in mainForm.dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string slot = row.Cells[5].Value?.ToString();
                string status = row.Cells[4].Value?.ToString(); // Active / Exited

                if (slot == null) continue;

                string slotNum = slot;

                foreach (DataGridViewRow slotRow in DVG_Slot.Rows)
                {
                    if (slotRow.Cells[0].Value.ToString() == slotNum)
                    {
                        if (status == "Active")
                            slotRow.Cells[2].Value = "Occupied";
                        else
                            slotRow.Cells[2].Value = "Vacant";

                        break;




                    }
                }
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_slotnum.Text == "")
            {
                MessageBox.Show("Enter Slot Number");
                return;
            }

            string slotNumber = txt_slotnum.Text;

            foreach (DataGridViewRow row in DVG_Slot.Rows)
            {
                if (row.Cells[0].Value.ToString() == slotNumber)
                {
                    row.Cells[1].Value = cmb_slottype.Text;
                    row.Cells[2].Value = cmb_status.Text;

                    UpdateAvailableSlots();
                    // Reflect change in ParkingSlot UI
                    if (mainForm.parkingSlot != null && !mainForm.parkingSlot.IsDisposed)
                    {
                        if (cmb_status.Text == "Vacant")
                            mainForm.parkingSlot.EnableSlot(slotNumber);
                        else if (cmb_status.Text == "Occupied")
                            mainForm.parkingSlot.OccupySlot(slotNumber);
                    }
                    ClearFields();

                    MessageBox.Show("Slot Updated via Add");
                    return;
                }
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            // Validate inputs
            if (string.IsNullOrWhiteSpace(txt_slotnum.Text))
            {
                MessageBox.Show("Slot Number is required to update.");
                return;
            }

            string slotNum = txt_slotnum.Text.Trim();

            // UPDATE FORM1
            for (int i = mainForm.dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = mainForm.dataGridView1.Rows[i];

                if (row.IsNewRow) continue;
                if (row.Cells[5].Value == null) continue;

                if (row.Cells[5].Value.ToString() == slotNum)
                {
                    if (cmb_status.Text == "Vacant")
                    {
                        // Remove vehicle record from Form1 and enable slot in ParkingSlot UI
                        if (mainForm.parkingSlot != null && !mainForm.parkingSlot.IsDisposed)
                        {
                            mainForm.parkingSlot.EnableSlot(slotNum);
                        }
                        mainForm.dataGridView1.Rows.RemoveAt(i);
                    }
                    else
                    {
                        row.Cells[4].Value = "Active";
                        row.Cells[2].Value = cmb_slottype.Text;
                    }

                    break;
                }
            }

            mainForm.UpdateParkingInfo();

            // UPDATE FORM3

            if (DVG_Slot.CurrentRow == null)
            {
                MessageBox.Show("Select a row first");
                return;
            }

            int index = DVG_Slot.CurrentRow.Index;

            // Do not overwrite values with empty fields; only update provided values
            if (!string.IsNullOrWhiteSpace(txt_slotnum.Text))
                DVG_Slot.Rows[index].Cells[0].Value = txt_slotnum.Text.Trim();

            if (cmb_slottype.SelectedItem != null)
                DVG_Slot.Rows[index].Cells[1].Value = cmb_slottype.SelectedItem.ToString();

            if (cmb_status.SelectedItem != null)
                DVG_Slot.Rows[index].Cells[2].Value = cmb_status.SelectedItem.ToString();

            UpdateAvailableSlots();

            // Reflect change to ParkingSlot UI for this slot
            string updatedSlot = DVG_Slot.Rows[index].Cells[0].Value?.ToString();
            if (!string.IsNullOrEmpty(updatedSlot) && mainForm.parkingSlot != null && !mainForm.parkingSlot.IsDisposed)
            {
                if (cmb_status.Text == "Vacant")
                    mainForm.parkingSlot.EnableSlot(updatedSlot);
                else if (cmb_status.Text == "Occupied")
                    mainForm.parkingSlot.OccupySlot(updatedSlot);
            }

            MessageBox.Show("Successfully Updated");

            ClearFields();
            DVG_Slot.ClearSelection();

        }



        private void ClearFields()
        {
            txt_slotnum.Clear();
            cmb_slottype.SelectedIndex = -1;
            cmb_status.SelectedIndex = -1;
        }
        public void UpdateSlot(string slotNumber, string SlotType, string Stat)
        {
            foreach (DataGridViewRow row in DVG_Slot.Rows)
            {
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() == slotNumber)
                {
                    row.Cells[1].Value = SlotType;
                    row.Cells[2].Value = Stat;
                    break;
                }
            }

            UpdateAvailableSlots();
        }

        public void UpdateSlotStatus(string slotNum, string Stat)
        {
            foreach (DataGridViewRow row in DVG_Slot.Rows)
            {
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() == slotNum)
                {
                    row.Cells[2].Value = Stat;
                    break;
                }
            }

            UpdateAvailableSlots();


        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_parkingSlot_Click(object sender, EventArgs e)
        {
            this.Hide();

            Start startForm = new Start(mainForm);
            startForm.Show();
        }

        private void lblAvailable_Click(object sender, EventArgs e)
        {

        }

        private void txt_slotnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_occupiedSlot_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_occupiedSlot_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_parkedVehicle_Click(object sender, EventArgs e)
        {

        }

        private void btn_showSlot_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.mainForm != null && !this.mainForm.IsDisposed)
            {
                Form2 exitForm = new Form2(this.mainForm, this.mainForm.parkingSlot);
                exitForm.Show();
                exitForm.BringToFront();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
       
            this.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.mainForm != null && !this.mainForm.IsDisposed)
            {
                this.mainForm.Show();
                this.mainForm.BringToFront();
                this.Hide();
            }
        }
    }
}
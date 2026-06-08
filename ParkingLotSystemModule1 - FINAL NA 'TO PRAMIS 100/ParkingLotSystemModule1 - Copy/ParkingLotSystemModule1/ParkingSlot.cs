using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParkingLotSystemModule1
{
    public partial class ParkingSlot : Form
    {

        Form1 mainForm;
        private Dictionary<string, PictureBox> slotMap;
        public ParkingSlot(Form1 form)
        {
            InitializeComponent();
            
            mainForm = form;

            // create mapping for slot ids to pictureboxes
            slotMap = new Dictionary<string, PictureBox>(StringComparer.OrdinalIgnoreCase)
            {
                { "A1", pb_slot1 }, { "A2", pb_slot2 }, { "A3", pb_slot3 }, { "A4", pb_slot4 }, { "A5", pb_slot5 },
                { "B1", pb_slot6 }, { "B2", pb_slot7 }, { "B3", pb_slot8 }, { "B4", pb_slot9 }, { "B5", pb_slot10 }
            };
        }
        public void OccupySlot(string slotNumber)
        {
            if (string.IsNullOrWhiteSpace(slotNumber)) return;

            // Refresh internal state based on Form1 grid to avoid drifting states
            SyncSlotsWithForm1();

            // Only occupy requested slot if it's currently available
            if (slotMap.TryGetValue(slotNumber.Trim(), out var pb))
            {
                if (pb.Enabled)
                {
                    pb.Enabled = false;
                    pb.BackColor = Color.Red;
                }
            }
        }

        private void pb_slot1_Click(object sender, EventArgs e)
        {
            Form1.Parkingslot = "A1";

            mainForm.lbl_Slot.Text = "A1";

            this.Hide();
        }

        private void pb_slot2_Click(object sender, EventArgs e)
        {
            Form1.Parkingslot = "A2";

            mainForm.lbl_Slot.Text = "A2";

            this.Hide();
        }

        private void pb_slot3_Click(object sender, EventArgs e)
        {
            Form1.Parkingslot = "A3";

            mainForm.lbl_Slot.Text = "A3";

            this.Hide();
        }

        private void pb_slot4_Click(object sender, EventArgs e)
        {
            Form1.Parkingslot = "A4";

            mainForm.lbl_Slot.Text = "A4";

            this.Hide();
        }

        private void pb_slot5_Click(object sender, EventArgs e)
        {
            Form1.Parkingslot = "A5";

            mainForm.lbl_Slot.Text = "A5";

            this.Hide();
        }

        private void pb_slot6_Click(object sender, EventArgs e)
        {
            Form1.Parkingslot = "B1";

            mainForm.lbl_Slot.Text = "B1";

            this.Hide();
        }

        private void pb_slot7_Click(object sender, EventArgs e)
        {
            Form1.Parkingslot = "B2";

            mainForm.lbl_Slot.Text = "B2";

            this.Hide();
        }

        private void pb_slot8_Click(object sender, EventArgs e)
        {
            Form1.Parkingslot = "B3";

            mainForm.lbl_Slot.Text = "B3";

            this.Hide();
        }

        private void pb_slot9_Click(object sender, EventArgs e)
        {
            Form1.Parkingslot = "B4";

            mainForm.lbl_Slot.Text = "B4";

            this.Hide();
        }

        private void pb_slot10_Click(object sender, EventArgs e)
        {
            Form1.Parkingslot = "B5";

            mainForm.lbl_Slot.Text = "B5";

            this.Hide();
        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool initialized = false;

        private void ParkingSlot_Load(object sender, EventArgs e)
        {
            if (!initialized)
            {
                pb_slot1.BackColor = Color.LimeGreen;
                pb_slot2.BackColor = Color.LimeGreen;
                pb_slot3.BackColor = Color.LimeGreen;
                pb_slot4.BackColor = Color.LimeGreen;
                pb_slot5.BackColor = Color.LimeGreen;
                pb_slot6.BackColor = Color.LimeGreen;
                pb_slot7.BackColor = Color.LimeGreen;
                pb_slot8.BackColor = Color.LimeGreen;
                pb_slot9.BackColor = Color.LimeGreen;
                pb_slot10.BackColor = Color.LimeGreen;

                pb_slot1.Enabled = true;
                pb_slot2.Enabled = true;
                pb_slot3.Enabled = true;
                pb_slot4.Enabled = true;
                pb_slot5.Enabled = true;
                pb_slot6.Enabled = true;
                pb_slot7.Enabled = true;
                pb_slot8.Enabled = true;
                pb_slot9.Enabled = true;
                pb_slot10.Enabled = true;

                initialized = true;
            }

            // Ensure visual state reflects main form data
            SyncSlotsWithForm1();
        }


        public void EnableSlot(string slotNumber) // bago to enable ung slot pag na exit ung vehicle ARAY MO 
        {
            if (string.IsNullOrWhiteSpace(slotNumber)) return;

            if (slotMap.TryGetValue(slotNumber.Trim(), out var pb))
            {
                pb.Enabled = true;
                pb.BackColor = Color.LimeGreen;
            }
            else
            {
                // Ensure UI is in sync if unknown slot passed
                SyncSlotsWithForm1();
            }
        }

        private void SyncSlotsWithForm1()
        {
            if (mainForm == null) return;

            // Determine occupied slots from Form1's data grid
            var occupied = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (DataGridViewRow row in mainForm.dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                var status = row.Cells[4].Value?.ToString();
                var slot = row.Cells[5].Value?.ToString();
                if (string.IsNullOrWhiteSpace(slot)) continue;
                if (status != null && status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    occupied.Add(slot.Trim());
                }
            }

            // Update pictureboxes to match occupied set
            foreach (var kvp in slotMap)
            {
                var id = kvp.Key;
                var pb = kvp.Value;
                if (occupied.Contains(id))
                {
                    pb.Enabled = false;
                    pb.BackColor = Color.Red;
                }
                else
                {
                    pb.Enabled = true;
                    pb.BackColor = Color.LimeGreen;
                }
            }
        }
    }
}

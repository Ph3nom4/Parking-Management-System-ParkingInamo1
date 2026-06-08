namespace ParkingLotSystemModule1
{
    public partial class Form1 : Form
    {

        public ParkingSlot parkingSlot;


        public Form3 slotManager;
        public Start startForm;



        public Form1()
        {
            InitializeComponent();

            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
        }



        string[] VehicleType = { "Motorcycle", "Car", "Van and Pickup Trucks", "Trucks and Buses" }; //Contatiner for Cbo

        public static string Parkingslot = "";

        public void UpdateAvailableSlots(int available)
        {
            lblAvailableSlots.Text = available.ToString();
        }

        public void UpdateParkingInfo()
        {
            int parkedVehicles = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string status = row.Cells[4].Value?.ToString();

                if (status == "Active")
                {
                    parkedVehicles++;
                }
            }

            int available = 10 - parkedVehicles;

            lbl_vehicleSparked.Text = parkedVehicles.ToString();
            lbl_OccupiedSlot.Text = parkedVehicles.ToString();
            lblAvailableSlots.Text = available.ToString();
        }

        private void tb_plateNum_TextChanged(object sender, EventArgs e)
        {
            // Ensure only digits are present and max length is enforced (sanitizes pasted text)
            if (tb_plateNum == null) return;
            // Allow letters and digits only (sanitizes pasted text)
            string alnumOnly = "";
            foreach (char c in tb_plateNum.Text)
            {
                if (char.IsLetterOrDigit(c)) alnumOnly += c;
            }

            if (alnumOnly.Length > 6)
                alnumOnly = alnumOnly.Substring(0, 6);

            if (tb_plateNum.Text != alnumOnly)
            {
                int selStart = tb_plateNum.SelectionStart;
                tb_plateNum.Text = alnumOnly;
                tb_plateNum.SelectionStart = Math.Min(selStart, tb_plateNum.Text.Length);
            }
        }

        private void tb_ownerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_vehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            

            // NOW occupy slot visually
            parkingSlot.OccupySlot(Form1.Parkingslot);

            if (tb_ownerName.Text == "" ||
              tb_plateNum.Text == "" ||
               cbo_vehicleType.SelectedItem == null ||
               Parkingslot == "")
            {
                MessageBox.Show("Please Input all Required Fields");
                return;
            }


            DateTime selectedTime = dateTimePicker1.Value; // dates for the future are not allowed

            if (selectedTime > DateTime.Now)
            {
                MessageBox.Show("Future dates and times are not allowed!");
                return;
            }

            // duplicate plate check
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells[0].Value?.ToString() == tb_plateNum.Text)
                {
                    MessageBox.Show("Plate Number already exists!");
                    return;
                }
            }

            // parking full check
            if (dataGridView1.Rows.Count >= 10)
            {
                MessageBox.Show("Parking Full");
                return;
            }



            string slotNumber = Parkingslot;



            // Use the shared Form3 instance and keep the slotManager reference in sync
            var mgr = Form3.GetInstance(this);
            slotManager = mgr;


            // Update slot state  Form3  DGV in the background without showing Form3
            mgr.UpdateSlot(
                slotNumber,
                cbo_vehicleType.Text,
                "Occupied"
            );

            // add vehicle
            dataGridView1.Rows.Add(
                tb_plateNum.Text,
                tb_ownerName.Text,
                cbo_vehicleType.Text,
                dateTimePicker1.Value,
                "Active",
                Parkingslot
            );

            parkingSlot?.OccupySlot(Parkingslot);

            UpdateParkingInfo();


            dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;




            Parkingslot = "";
            lbl_Slot.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (string Vehicle in VehicleType) // Cbo
            {
                cbo_vehicleType.Items.Add(Vehicle);

            }

            dateTimePicker1.Format = DateTimePickerFormat.Custom; //time format
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker1.Value = DateTime.Now;



            UpdateParkingInfo();


        }

        private void btn_parkingSlot_Click(object sender, EventArgs e) // open parking slot form
        {
            // Ensure the ParkingSlot form instance exists and is visible/active
            if (parkingSlot == null || parkingSlot.IsDisposed)
            {
                parkingSlot = new ParkingSlot(this);
            }

            // If it was minimized, restore
            try
            {
                if (parkingSlot.WindowState == FormWindowState.Minimized)
                    parkingSlot.WindowState = FormWindowState.Normal;
            }
            catch { }

            if (!parkingSlot.Visible)
                parkingSlot.Show();

            // Ensure it's in front and focused so clicks register reliably
            parkingSlot.BringToFront();
            parkingSlot.Activate();
            parkingSlot.Focus();


        }

        private void button2_Click(object sender, EventArgs e) // open exit form
        {
            Form2 exitForm = new Form2(this, parkingSlot);
            exitForm.Show();
            this.Show();

        }

        private void btn_exit_Click(object sender, EventArgs e) // x button
        {
            Application.Exit();
        }


        private void btn_return_Click(object sender, EventArgs e) // return to start form button
        {
            if (startForm == null || startForm.IsDisposed)
            {

                startForm = new Start(this);
            }

            startForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void SetSelectedSlot(string slot) // update ng slot number sa form1 pag nag click sa slot sa form3
        {
            Parkingslot = slot;
            lbl_Slot.Text = slot;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 exitForm = new Form2(this, this.parkingSlot);
            exitForm.Show();
            exitForm.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.slotManager == null || this.slotManager.IsDisposed)
            {
                this.slotManager = new Form3(this);
            }

            this.slotManager.Show();
            this.slotManager.BringToFront();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_vehicleExit_Click(object sender, EventArgs e)
        {
            Form2 exitForm = new Form2(this, parkingSlot);
            exitForm.Show();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_Slot_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tb_plateNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace), letters and digits only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}





//ph3nom
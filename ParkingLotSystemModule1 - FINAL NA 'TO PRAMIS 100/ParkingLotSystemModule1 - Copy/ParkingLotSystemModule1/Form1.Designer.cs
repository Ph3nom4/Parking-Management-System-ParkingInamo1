namespace ParkingLotSystemModule1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_plateNum = new TextBox();
            tb_ownerName = new TextBox();
            dataGridView1 = new DataGridView();
            PlateNumber = new DataGridViewTextBoxColumn();
            OwnerName = new DataGridViewTextBoxColumn();
            Vehiclety = new DataGridViewTextBoxColumn();
            TimeIn = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ParkingSlot = new DataGridViewTextBoxColumn();
            cbo_vehicleType = new ComboBox();
            btn_Enter = new Button();
            dateTimePicker1 = new DateTimePicker();
            btn_parkingSlot = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_vehicleExit = new Button();
            label4 = new Label();
            lbl_Slot = new Label();
            label6 = new Label();
            btn_return = new Button();
            lblAvailableSlots = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            button2 = new Button();
            button1 = new Button();
            label19 = new Label();
            groupBox1 = new GroupBox();
            lbl_vehicleSparked = new Label();
            lbl_OccupiedSlot = new Label();
            lbl_total_Slots = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            label14 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_plateNum
            // 
            tb_plateNum.BorderStyle = BorderStyle.FixedSingle;
            tb_plateNum.Location = new Point(337, 45);
            tb_plateNum.Margin = new Padding(3, 4, 3, 4);
            tb_plateNum.Name = "tb_plateNum";
            tb_plateNum.Size = new Size(232, 27);
            tb_plateNum.TabIndex = 0;
            tb_plateNum.TextChanged += tb_plateNum_TextChanged;
            // 
            // tb_ownerName
            // 
            tb_ownerName.BorderStyle = BorderStyle.FixedSingle;
            tb_ownerName.Location = new Point(45, 45);
            tb_ownerName.Margin = new Padding(3, 4, 3, 4);
            tb_ownerName.Name = "tb_ownerName";
            tb_ownerName.Size = new Size(228, 27);
            tb_ownerName.TabIndex = 1;
            tb_ownerName.TextChanged += tb_ownerName_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PlateNumber, OwnerName, Vehiclety, TimeIn, Status, ParkingSlot });
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(267, 381);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(861, 403);
            dataGridView1.TabIndex = 2;
            // 
            // PlateNumber
            // 
            PlateNumber.HeaderText = "PlateNumber";
            PlateNumber.MinimumWidth = 6;
            PlateNumber.Name = "PlateNumber";
            // 
            // OwnerName
            // 
            OwnerName.HeaderText = "OwnerName";
            OwnerName.MinimumWidth = 6;
            OwnerName.Name = "OwnerName";
            // 
            // Vehiclety
            // 
            Vehiclety.HeaderText = "VehicleType";
            Vehiclety.MinimumWidth = 6;
            Vehiclety.Name = "Vehiclety";
            // 
            // TimeIn
            // 
            TimeIn.HeaderText = "Time In";
            TimeIn.MinimumWidth = 6;
            TimeIn.Name = "TimeIn";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // ParkingSlot
            // 
            ParkingSlot.HeaderText = "ParkingSlot";
            ParkingSlot.MinimumWidth = 6;
            ParkingSlot.Name = "ParkingSlot";
            // 
            // cbo_vehicleType
            // 
            cbo_vehicleType.FormattingEnabled = true;
            cbo_vehicleType.Location = new Point(45, 112);
            cbo_vehicleType.Margin = new Padding(3, 4, 3, 4);
            cbo_vehicleType.Name = "cbo_vehicleType";
            cbo_vehicleType.Size = new Size(228, 28);
            cbo_vehicleType.TabIndex = 3;
            cbo_vehicleType.SelectedIndexChanged += cbo_vehicleType_SelectedIndexChanged;
            // 
            // btn_Enter
            // 
            btn_Enter.BackColor = Color.MediumSeaGreen;
            btn_Enter.FlatAppearance.BorderSize = 0;
            btn_Enter.FlatStyle = FlatStyle.Flat;
            btn_Enter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_Enter.Location = new Point(29, 25);
            btn_Enter.Margin = new Padding(3, 4, 3, 4);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new Size(239, 40);
            btn_Enter.TabIndex = 4;
            btn_Enter.Text = "🚘Enter";
            btn_Enter.UseVisualStyleBackColor = false;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(337, 112);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // btn_parkingSlot
            // 
            btn_parkingSlot.BackColor = Color.Gold;
            btn_parkingSlot.FlatAppearance.BorderSize = 0;
            btn_parkingSlot.FlatStyle = FlatStyle.Flat;
            btn_parkingSlot.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_parkingSlot.Location = new Point(312, 25);
            btn_parkingSlot.Margin = new Padding(3, 4, 3, 4);
            btn_parkingSlot.Name = "btn_parkingSlot";
            btn_parkingSlot.Size = new Size(239, 40);
            btn_parkingSlot.TabIndex = 6;
            btn_parkingSlot.Text = "🅿️ Parking Slot";
            btn_parkingSlot.UseVisualStyleBackColor = false;
            btn_parkingSlot.Click += btn_parkingSlot_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 19);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 8;
            label1.Text = "Plate Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(45, 19);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 8;
            label2.Text = "Owner Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(45, 84);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 8;
            label3.Text = "Vehicle Type:";
            // 
            // btn_vehicleExit
            // 
            btn_vehicleExit.BackColor = Color.LightCoral;
            btn_vehicleExit.FlatAppearance.BorderSize = 0;
            btn_vehicleExit.FlatStyle = FlatStyle.Flat;
            btn_vehicleExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_vehicleExit.Location = new Point(593, 25);
            btn_vehicleExit.Margin = new Padding(3, 4, 3, 4);
            btn_vehicleExit.Name = "btn_vehicleExit";
            btn_vehicleExit.Size = new Size(239, 40);
            btn_vehicleExit.TabIndex = 9;
            btn_vehicleExit.Text = "Vehicle Exit";
            btn_vehicleExit.UseVisualStyleBackColor = false;
            btn_vehicleExit.Click += btn_vehicleExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(6, 12);
            label4.Name = "label4";
            label4.Size = new Size(232, 28);
            label4.TabIndex = 13;
            label4.Text = "PARKING NG INA MO ";
            label4.Click += label4_Click;
            // 
            // lbl_Slot
            // 
            lbl_Slot.AutoSize = true;
            lbl_Slot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Slot.ForeColor = Color.DodgerBlue;
            lbl_Slot.Location = new Point(95, 120);
            lbl_Slot.Name = "lbl_Slot";
            lbl_Slot.Size = new Size(24, 28);
            lbl_Slot.TabIndex = 14;
            lbl_Slot.Text = "0";
            lbl_Slot.Click += lbl_Slot_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(41, 92);
            label6.Name = "label6";
            label6.Size = new Size(135, 28);
            label6.TabIndex = 14;
            label6.Text = "Selected Slot";
            // 
            // btn_return
            // 
            btn_return.BackColor = Color.FromArgb(1, 95, 221);
            btn_return.FlatStyle = FlatStyle.Popup;
            btn_return.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_return.ForeColor = Color.White;
            btn_return.Location = new Point(4, 292);
            btn_return.Margin = new Padding(3, 4, 3, 4);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(224, 59);
            btn_return.TabIndex = 15;
            btn_return.Text = "Return to main screen";
            btn_return.UseVisualStyleBackColor = false;
            btn_return.Click += btn_return_Click;
            // 
            // lblAvailableSlots
            // 
            lblAvailableSlots.AutoSize = true;
            lblAvailableSlots.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAvailableSlots.ForeColor = Color.MediumSeaGreen;
            lblAvailableSlots.Location = new Point(83, 51);
            lblAvailableSlots.Name = "lblAvailableSlots";
            lblAvailableSlots.Size = new Size(36, 28);
            lblAvailableSlots.TabIndex = 16;
            lblAvailableSlots.Text = "10";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(337, 84);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 19;
            label5.Text = "Time in:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(cbo_vehicleType);
            groupBox2.Controls.Add(tb_ownerName);
            groupBox2.Controls.Add(tb_plateNum);
            groupBox2.Location = new Point(267, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(625, 169);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(lbl_Slot);
            groupBox3.Controls.Add(lblAvailableSlots);
            groupBox3.Location = new Point(912, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(216, 169);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 23);
            label8.Name = "label8";
            label8.Size = new Size(152, 28);
            label8.TabIndex = 27;
            label8.Text = "Available Slots";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(10, 37);
            label7.Name = "label7";
            label7.Size = new Size(88, 17);
            label7.TabIndex = 22;
            label7.Text = "Vehicle Entry";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 30, 62);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btn_return);
            panel1.Controls.Add(label19);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 853);
            panel1.TabIndex = 23;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(1, 95, 221);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(4, 227);
            button3.Name = "button3";
            button3.Size = new Size(224, 59);
            button3.TabIndex = 33;
            button3.Text = "🛠️ Manage";
            button3.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(5, 351);
            label13.Name = "label13";
            label13.Size = new Size(225, 20);
            label13.TabIndex = 31;
            label13.Text = "____________________________________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(10, 425);
            label12.Name = "label12";
            label12.Size = new Size(225, 180);
            label12.TabIndex = 30;
            label12.Text = "Motorcycle           ₱20 - 10/hr\r\n\r\nCar                         ₱50 - 25/hr\r\n\r\nVan                        ₱65 - 35/hr\r\n\r\nPickup Trucks       ₱65 - 35/hr\r\n\r\nBus and Trucks    ₱100 - 50/hr \r\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(14, 371);
            label11.Name = "label11";
            label11.Size = new Size(142, 28);
            label11.TabIndex = 29;
            label11.Text = "Parking Rates";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(1, 95, 221);
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(4, 162);
            button2.Name = "button2";
            button2.Size = new Size(224, 59);
            button2.TabIndex = 28;
            button2.Text = "Vehicle Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 95, 221);
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(4, 97);
            button1.Name = "button1";
            button1.Size = new Size(224, 59);
            button1.TabIndex = 27;
            button1.Text = "🚘Vehicle Entry";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(14, 396);
            label19.Name = "label19";
            label19.Size = new Size(213, 17);
            label19.TabIndex = 32;
            label19.Text = "(Parking rate) - (Charge per Hour)";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(lbl_vehicleSparked);
            groupBox1.Controls.Add(lbl_OccupiedSlot);
            groupBox1.Controls.Add(lbl_total_Slots);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(1153, 88);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 337);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // lbl_vehicleSparked
            // 
            lbl_vehicleSparked.AutoSize = true;
            lbl_vehicleSparked.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_vehicleSparked.ForeColor = Color.Gold;
            lbl_vehicleSparked.Location = new Point(105, 281);
            lbl_vehicleSparked.Name = "lbl_vehicleSparked";
            lbl_vehicleSparked.Size = new Size(24, 28);
            lbl_vehicleSparked.TabIndex = 31;
            lbl_vehicleSparked.Text = "0";
            // 
            // lbl_OccupiedSlot
            // 
            lbl_OccupiedSlot.AutoSize = true;
            lbl_OccupiedSlot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_OccupiedSlot.ForeColor = Color.Red;
            lbl_OccupiedSlot.Location = new Point(105, 203);
            lbl_OccupiedSlot.Name = "lbl_OccupiedSlot";
            lbl_OccupiedSlot.Size = new Size(24, 28);
            lbl_OccupiedSlot.TabIndex = 31;
            lbl_OccupiedSlot.Text = "0";
            // 
            // lbl_total_Slots
            // 
            lbl_total_Slots.AutoSize = true;
            lbl_total_Slots.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total_Slots.ForeColor = SystemColors.ActiveCaptionText;
            lbl_total_Slots.Location = new Point(95, 109);
            lbl_total_Slots.Name = "lbl_total_Slots";
            lbl_total_Slots.Size = new Size(36, 28);
            lbl_total_Slots.TabIndex = 31;
            lbl_total_Slots.Text = "10";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(43, 244);
            label18.Name = "label18";
            label18.Size = new Size(160, 28);
            label18.TabIndex = 30;
            label18.Text = "Vehicles Parked";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(63, 72);
            label17.Name = "label17";
            label17.Size = new Size(111, 28);
            label17.TabIndex = 29;
            label17.Text = "Total Slots";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(43, 159);
            label16.Name = "label16";
            label16.Size = new Size(152, 28);
            label16.TabIndex = 28;
            label16.Text = "Occupied Slots";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 20);
            label9.Name = "label9";
            label9.Size = new Size(155, 23);
            label9.TabIndex = 27;
            label9.Text = "Parking Summary";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(btn_Enter);
            groupBox4.Controls.Add(btn_parkingSlot);
            groupBox4.Controls.Add(btn_vehicleExit);
            groupBox4.Location = new Point(267, 275);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(861, 85);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(1153, 448);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(229, 337);
            groupBox5.TabIndex = 26;
            groupBox5.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 75);
            label14.Name = "label14";
            label14.Size = new Size(214, 20);
            label14.TabIndex = 29;
            label14.Text = "System Version: Alpha test V3.0\r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(16, 24);
            label10.Name = "label10";
            label10.Size = new Size(169, 23);
            label10.TabIndex = 28;
            label10.Text = "System Information";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(1, 30, 62);
            pictureBox1.Location = new Point(215, -20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1248, 85);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(1424, 804);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_plateNum;
        private TextBox tb_ownerName;
        private ComboBox cbo_vehicleType;
        private Button btn_Enter;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn PlateNumber;
        private DataGridViewTextBoxColumn OwnerName;
        private DataGridViewTextBoxColumn Vehiclety;
        private DataGridViewTextBoxColumn TimeIn;
        private DataGridViewTextBoxColumn Status;
        public DataGridViewTextBoxColumn ParkingSlot;
        private Button btn_parkingSlot;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_vehicleExit;
        public DataGridView dataGridView1;
        private Label label4;
        private Label label6;
        public Label lbl_Slot;
        private Button btn_return;
        private Label lblAvailableSlots;
        private Button btnRate;
        private Label label5;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label7;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button button2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label11;
        private Label label13;
        private PictureBox pictureBox1;
        private Label label14;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label19;
        private Button button3;
        private Label lbl_OccupiedSlot;
        private Label lbl_total_Slots;
        private Label lbl_vehicleSparked;
    }
}

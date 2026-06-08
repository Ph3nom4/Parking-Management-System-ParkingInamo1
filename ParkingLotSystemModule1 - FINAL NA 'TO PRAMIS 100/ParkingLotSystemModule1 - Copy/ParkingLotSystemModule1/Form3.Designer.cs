namespace ParkingLotSystemModule1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            btn_update = new Button();
            btn_add = new Button();
            DVG_Slot = new DataGridView();
            Slot = new DataGridViewTextBoxColumn();
            SlotType = new DataGridViewTextBoxColumn();
            Stat = new DataGridViewTextBoxColumn();
            cmb_status = new ComboBox();
            cmb_slottype = new ComboBox();
            txt_slotnum = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            lblAvailable = new Label();
            btn_parkingSlot = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            lbl_occupiedSlot = new Label();
            label5 = new Label();
            groupBox4 = new GroupBox();
            label6 = new Label();
            lbl_parkedVehicle = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVG_Slot).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(DVG_Slot);
            groupBox1.Controls.Add(cmb_status);
            groupBox1.Controls.Add(cmb_slottype);
            groupBox1.Controls.Add(txt_slotnum);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(257, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(882, 574);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parking Slot Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 201);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 9;
            label4.Text = "Parking Slot List";
            // 
            // btn_update
            // 
            btn_update.ForeColor = SystemColors.ControlText;
            btn_update.Location = new Point(743, 65);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 36);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.ForeColor = SystemColors.ControlText;
            btn_add.Location = new Point(743, 148);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 37);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // DVG_Slot
            // 
            DVG_Slot.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DVG_Slot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVG_Slot.Columns.AddRange(new DataGridViewColumn[] { Slot, SlotType, Stat });
            DVG_Slot.Location = new Point(29, 224);
            DVG_Slot.Name = "DVG_Slot";
            DVG_Slot.RowHeadersVisible = false;
            DVG_Slot.RowHeadersWidth = 51;
            DVG_Slot.Size = new Size(825, 325);
            DVG_Slot.TabIndex = 8;
            DVG_Slot.CellContentClick += DVG_Slot_CellContentClick;
            // 
            // Slot
            // 
            Slot.HeaderText = "Slot Num";
            Slot.MinimumWidth = 6;
            Slot.Name = "Slot";
            // 
            // SlotType
            // 
            SlotType.HeaderText = "Slot Type";
            SlotType.MinimumWidth = 6;
            SlotType.Name = "SlotType";
            // 
            // Stat
            // 
            Stat.HeaderText = "Status";
            Stat.MinimumWidth = 6;
            Stat.Name = "Stat";
            // 
            // cmb_status
            // 
            cmb_status.FormattingEnabled = true;
            cmb_status.Location = new Point(162, 149);
            cmb_status.Name = "cmb_status";
            cmb_status.Size = new Size(530, 31);
            cmb_status.TabIndex = 5;
            // 
            // cmb_slottype
            // 
            cmb_slottype.FormattingEnabled = true;
            cmb_slottype.Location = new Point(162, 99);
            cmb_slottype.Name = "cmb_slottype";
            cmb_slottype.Size = new Size(530, 31);
            cmb_slottype.TabIndex = 4;
            // 
            // txt_slotnum
            // 
            txt_slotnum.Location = new Point(162, 47);
            txt_slotnum.Name = "txt_slotnum";
            txt_slotnum.Size = new Size(530, 30);
            txt_slotnum.TabIndex = 3;
            txt_slotnum.TextChanged += txt_slotnum_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(37, 148);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 2;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(37, 97);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 1;
            label2.Text = "Slot Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(37, 45);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 0;
            label1.Text = "Slot Number:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gainsboro;
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(lblAvailable);
            groupBox2.Location = new Point(1168, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 151);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(45, 29);
            label9.Name = "label9";
            label9.Size = new Size(154, 28);
            label9.TabIndex = 11;
            label9.Text = "Available Slot :";
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailable.ForeColor = SystemColors.ControlText;
            lblAvailable.Location = new Point(102, 86);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(24, 28);
            lblAvailable.TabIndex = 10;
            lblAvailable.Text = "0";
            lblAvailable.Click += lblAvailable_Click;
            // 
            // btn_parkingSlot
            // 
            btn_parkingSlot.BackColor = Color.FromArgb(1, 95, 221);
            btn_parkingSlot.FlatStyle = FlatStyle.Popup;
            btn_parkingSlot.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_parkingSlot.ForeColor = Color.White;
            btn_parkingSlot.Location = new Point(5, 288);
            btn_parkingSlot.Margin = new Padding(3, 4, 3, 4);
            btn_parkingSlot.Name = "btn_parkingSlot";
            btn_parkingSlot.Size = new Size(224, 59);
            btn_parkingSlot.TabIndex = 11;
            btn_parkingSlot.Text = "<<  Return";
            btn_parkingSlot.UseVisualStyleBackColor = false;
            btn_parkingSlot.Click += btn_parkingSlot_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(1, 30, 62);
            pictureBox1.Location = new Point(233, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1249, 67);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 30, 62);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btn_parkingSlot);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 853);
            panel1.TabIndex = 26;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(1, 95, 221);
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(5, 224);
            button2.Name = "button2";
            button2.Size = new Size(224, 59);
            button2.TabIndex = 25;
            button2.Text = "Manage";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 95, 221);
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 161);
            button1.Name = "button1";
            button1.Size = new Size(224, 59);
            button1.TabIndex = 24;
            button1.Text = "Vehicle Exit";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(1, 95, 221);
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(6, 97);
            button3.Name = "button3";
            button3.Size = new Size(224, 59);
            button3.TabIndex = 23;
            button3.Text = "🚘 Vehicle Entry";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(8, 13);
            label7.Name = "label7";
            label7.Size = new Size(232, 28);
            label7.TabIndex = 13;
            label7.Text = "PARKING NG INA MO ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(10, 37);
            label8.Name = "label8";
            label8.Size = new Size(187, 17);
            label8.TabIndex = 22;
            label8.Text = "Parking Management System";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gainsboro;
            groupBox3.Controls.Add(lbl_occupiedSlot);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(1167, 276);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(227, 151);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lbl_occupiedSlot
            // 
            lbl_occupiedSlot.AutoSize = true;
            lbl_occupiedSlot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_occupiedSlot.Location = new Point(103, 79);
            lbl_occupiedSlot.Name = "lbl_occupiedSlot";
            lbl_occupiedSlot.Size = new Size(24, 28);
            lbl_occupiedSlot.TabIndex = 12;
            lbl_occupiedSlot.Text = "0";
            lbl_occupiedSlot.Click += lbl_occupiedSlot_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 24);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 11;
            label5.Text = "Occupied Slot";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Gainsboro;
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(lbl_parkedVehicle);
            groupBox4.Location = new Point(1167, 460);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(227, 151);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 24);
            label6.Name = "label6";
            label6.Size = new Size(151, 28);
            label6.TabIndex = 11;
            label6.Text = "Parked Vehicle";
            // 
            // lbl_parkedVehicle
            // 
            lbl_parkedVehicle.AutoSize = true;
            lbl_parkedVehicle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_parkedVehicle.ForeColor = SystemColors.ControlText;
            lbl_parkedVehicle.Location = new Point(103, 81);
            lbl_parkedVehicle.Name = "lbl_parkedVehicle";
            lbl_parkedVehicle.Size = new Size(24, 28);
            lbl_parkedVehicle.TabIndex = 10;
            lbl_parkedVehicle.Text = "0";
            lbl_parkedVehicle.Click += lbl_parkedVehicle_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(1424, 681);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DVG_Slot).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAvailable;
        private Label label4;
        private DataGridView DVG_Slot;
        private Button btn_update;
        private Button btn_add;
        private ComboBox cmb_status;
        private ComboBox cmb_slottype;
        private TextBox txt_slotnum;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Slot;
        private DataGridViewTextBoxColumn SlotType;
        private DataGridViewTextBoxColumn Stat;
        private Button btn_parkingSlot;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private Label label7;
        private Label label8;
        private GroupBox groupBox2;
        private Button button2;
        private GroupBox groupBox3;
        private Label Occupied_Slot;
        private GroupBox groupBox4;
        private Label lbl_parkedVehicle;
        private Label label5;
        private Label label9;
        private Label label6;
        private Label lbl_occupiedSlot;
        private Button button3;
    }
}
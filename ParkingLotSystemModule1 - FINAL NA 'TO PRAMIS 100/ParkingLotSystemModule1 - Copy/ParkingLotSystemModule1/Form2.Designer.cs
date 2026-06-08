namespace ParkingLotSystemModule1
{
    partial class Form2
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
            label2 = new Label();
            tb_plateNumber = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_search = new Button();
            btn_exitVehicle = new Button();
            lbl_timeIn = new Label();
            lbl_hoursStayed = new Label();
            lbl_totalFee = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            btn_exit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 92);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 1;
            label2.Text = "Plate Number";
            // 
            // tb_plateNumber
            // 
            tb_plateNumber.BorderStyle = BorderStyle.FixedSingle;
            tb_plateNumber.Location = new Point(40, 129);
            tb_plateNumber.Margin = new Padding(3, 4, 3, 4);
            tb_plateNumber.Name = "tb_plateNumber";
            tb_plateNumber.Size = new Size(333, 27);
            tb_plateNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(19, 33);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 1;
            label3.Text = "Time In:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(19, 101);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 1;
            label4.Text = "Hours Stayed :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(19, 175);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 1;
            label5.Text = "Total Fee :";
            label5.Click += label5_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.LightSteelBlue;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.Location = new Point(142, 183);
            btn_search.Margin = new Padding(3, 4, 3, 4);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(125, 29);
            btn_search.TabIndex = 3;
            btn_search.Text = "Search Vehicle";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_exitVehicle
            // 
            btn_exitVehicle.BackColor = Color.LightCoral;
            btn_exitVehicle.FlatStyle = FlatStyle.Popup;
            btn_exitVehicle.Location = new Point(142, 521);
            btn_exitVehicle.Margin = new Padding(3, 4, 3, 4);
            btn_exitVehicle.Name = "btn_exitVehicle";
            btn_exitVehicle.Size = new Size(125, 31);
            btn_exitVehicle.TabIndex = 3;
            btn_exitVehicle.Text = "EXIT VEHICLE";
            btn_exitVehicle.UseVisualStyleBackColor = false;
            btn_exitVehicle.Click += btn_exitVehicle_Click;
            // 
            // lbl_timeIn
            // 
            lbl_timeIn.AutoSize = true;
            lbl_timeIn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_timeIn.Location = new Point(175, 33);
            lbl_timeIn.Name = "lbl_timeIn";
            lbl_timeIn.Size = new Size(17, 20);
            lbl_timeIn.TabIndex = 4;
            lbl_timeIn.Text = "0";
            lbl_timeIn.Click += lbl_timeIn_Click;
            // 
            // lbl_hoursStayed
            // 
            lbl_hoursStayed.AutoSize = true;
            lbl_hoursStayed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_hoursStayed.Location = new Point(175, 101);
            lbl_hoursStayed.Name = "lbl_hoursStayed";
            lbl_hoursStayed.Size = new Size(17, 20);
            lbl_hoursStayed.TabIndex = 4;
            lbl_hoursStayed.Text = "0";
            lbl_hoursStayed.Click += lbl_hoursStayed_Click;
            // 
            // lbl_totalFee
            // 
            lbl_totalFee.AutoSize = true;
            lbl_totalFee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_totalFee.Location = new Point(175, 175);
            lbl_totalFee.Name = "lbl_totalFee";
            lbl_totalFee.Size = new Size(17, 20);
            lbl_totalFee.TabIndex = 4;
            lbl_totalFee.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(244, 246, 250);
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 19);
            label1.Name = "label1";
            label1.Size = new Size(266, 31);
            label1.TabIndex = 12;
            label1.Text = "PARKING NG INA MO ";
            label1.Click += label1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl_timeIn);
            groupBox1.Controls.Add(lbl_hoursStayed);
            groupBox1.Controls.Add(lbl_totalFee);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(37, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 232);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(161, 52);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 14;
            label6.Text = "Vehicle Exit";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(208, 0, 0);
            btn_exit.FlatStyle = FlatStyle.Popup;
            btn_exit.Location = new Point(358, 0);
            btn_exit.Margin = new Padding(3, 4, 3, 4);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(57, 28);
            btn_exit.TabIndex = 15;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(414, 605);
            Controls.Add(btn_exit);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(btn_exitVehicle);
            Controls.Add(btn_search);
            Controls.Add(tb_plateNumber);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehicle Exit Module";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox tb_plateNumber;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_search;
        private Button btn_exitVehicle;
        private Label lbl_timeIn;
        private Label lbl_hoursStayed;
        private Label lbl_totalFee;
        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Button btn_exit;
    }
}
namespace ParkingLotSystemModule1
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            label1 = new Label();
            label2 = new Label();
            btn_try1 = new Button();
            btn_try3 = new Button();
            btn_try2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            dateTimePicker3 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(1, 30, 62);
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 29);
            label1.Name = "label1";
            label1.Size = new Size(340, 41);
            label1.TabIndex = 0;
            label1.Text = "PARKING NG INA MO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(117, 65);
            label2.Name = "label2";
            label2.Size = new Size(205, 19);
            label2.TabIndex = 0;
            label2.Text = "Park safely at your own expense";
            // 
            // btn_try1
            // 
            btn_try1.BackColor = SystemColors.HighlightText;
            btn_try1.BackgroundImage = (Image)resources.GetObject("btn_try1.BackgroundImage");
            btn_try1.BackgroundImageLayout = ImageLayout.Stretch;
            btn_try1.FlatStyle = FlatStyle.Flat;
            btn_try1.ImageAlign = ContentAlignment.TopRight;
            btn_try1.ImageKey = "(none)";
            btn_try1.Location = new Point(163, 220);
            btn_try1.Margin = new Padding(3, 4, 3, 4);
            btn_try1.Name = "btn_try1";
            btn_try1.Size = new Size(265, 161);
            btn_try1.TabIndex = 1;
            btn_try1.UseVisualStyleBackColor = false;
            btn_try1.Click += btn_try1_Click;
            // 
            // btn_try3
            // 
            btn_try3.BackColor = SystemColors.HighlightText;
            btn_try3.BackgroundImage = (Image)resources.GetObject("btn_try3.BackgroundImage");
            btn_try3.BackgroundImageLayout = ImageLayout.Stretch;
            btn_try3.FlatStyle = FlatStyle.Flat;
            btn_try3.Location = new Point(485, 220);
            btn_try3.Margin = new Padding(3, 4, 3, 4);
            btn_try3.Name = "btn_try3";
            btn_try3.Size = new Size(265, 161);
            btn_try3.TabIndex = 1;
            btn_try3.UseVisualStyleBackColor = false;
            btn_try3.Click += btn_try3_Click;
            // 
            // btn_try2
            // 
            btn_try2.BackColor = Color.FromArgb(206, 0, 5);
            btn_try2.FlatStyle = FlatStyle.Flat;
            btn_try2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_try2.ForeColor = SystemColors.Desktop;
            btn_try2.Location = new Point(382, 516);
            btn_try2.Margin = new Padding(3, 4, 3, 4);
            btn_try2.Name = "btn_try2";
            btn_try2.Size = new Size(150, 40);
            btn_try2.TabIndex = 2;
            btn_try2.Text = "Exit ";
            btn_try2.UseVisualStyleBackColor = false;
            btn_try2.Click += btn_try2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkSeaGreen;
            pictureBox2.Location = new Point(163, 381);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 40);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightSteelBlue;
            pictureBox3.Location = new Point(485, 381);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(265, 39);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSeaGreen;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(207, 385);
            label3.Name = "label3";
            label3.Size = new Size(169, 28);
            label3.TabIndex = 8;
            label3.Text = "🚘Parking Entry";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSteelBlue;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(495, 385);
            label6.Name = "label6";
            label6.Size = new Size(243, 28);
            label6.TabIndex = 9;
            label6.Text = "🛠️Parking Management";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 30, 62);
            panel1.Controls.Add(dateTimePicker3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-54, -28);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 93);
            panel1.TabIndex = 10;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(839, 45);
            dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(107, 27);
            dateTimePicker3.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(303, 124);
            label7.Name = "label7";
            label7.Size = new Size(325, 41);
            label7.TabIndex = 12;
            label7.Text = "PARKING NG INA MO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(244, 246, 250);
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(250, 170, 42);
            label8.Location = new Point(384, 79);
            label8.Name = "label8";
            label8.Size = new Size(167, 41);
            label8.TabIndex = 12;
            label8.Text = "Welcome!";
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(914, 600);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btn_try2);
            Controls.Add(btn_try3);
            Controls.Add(btn_try1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start";
            Load += Start_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_try1;
        private Button button2b;
        private Button btn_try3;
        private Button btn_try2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label6;
        private Panel panel1;
        private DateTimePicker dateTimePicker3;
        private Label label7;
        private Label label8;
    }
}
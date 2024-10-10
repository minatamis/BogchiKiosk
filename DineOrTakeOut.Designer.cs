namespace BogchiKiosk
{
    partial class DineOrTakeOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DineOrTakeOut));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(273, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 499);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            label2.Location = new Point(187, 557);
            label2.Name = "label2";
            label2.Size = new Size(726, 62);
            label2.TabIndex = 2;
            label2.Text = "Where will you be eating today?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(213, 665);
            button1.Name = "button1";
            button1.Size = new Size(303, 158);
            button1.TabIndex = 3;
            button1.Text = "FOR HERE";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(522, 665);
            button2.Name = "button2";
            button2.Size = new Size(303, 158);
            button2.TabIndex = 4;
            button2.Text = "TAKE OUT";
            button2.UseVisualStyleBackColor = false;
            // 
            // DineOrTakeOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 237, 227);
            ClientSize = new Size(1080, 1100);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DineOrTakeOut";
            Text = "DineOrTakeOut";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
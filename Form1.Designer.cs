namespace Random_Pin_Generator {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblPinNo = new Label();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // lblPinNo
            // 
            lblPinNo.AutoSize = true;
            lblPinNo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPinNo.ForeColor = Color.Blue;
            lblPinNo.Location = new Point(19, 34);
            lblPinNo.Name = "lblPinNo";
            lblPinNo.Size = new Size(250, 37);
            lblPinNo.TabIndex = 0;
            lblPinNo.Text = "Your Pin Number: ";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Yellow;
            btnGenerate.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnGenerate.FlatAppearance.BorderSize = 3;
            btnGenerate.Font = new Font("Ink Free", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(50, 109);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(305, 45);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate Pin Number";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 178);
            Controls.Add(btnGenerate);
            Controls.Add(lblPinNo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Random Pin Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPinNo;
        private Button btnGenerate;
    }
}

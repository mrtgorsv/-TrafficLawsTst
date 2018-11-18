namespace TrafficLawsTest.Controls
{
    partial class StartUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StartTestButton = new System.Windows.Forms.Button();
            this.ShowTestStatisticButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.StartTestButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ShowTestStatisticButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StartTestButton
            // 
            this.StartTestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTestButton.Location = new System.Drawing.Point(3, 437);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(266, 74);
            this.StartTestButton.TabIndex = 0;
            this.StartTestButton.Text = "Пройти тест";
            this.StartTestButton.UseVisualStyleBackColor = true;
            // 
            // ShowTestStatisticButton
            // 
            this.ShowTestStatisticButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowTestStatisticButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowTestStatisticButton.Location = new System.Drawing.Point(275, 437);
            this.ShowTestStatisticButton.Name = "ShowTestStatisticButton";
            this.ShowTestStatisticButton.Size = new System.Drawing.Size(266, 74);
            this.ShowTestStatisticButton.TabIndex = 1;
            this.ShowTestStatisticButton.Text = "Прошлые тестирования";
            this.ShowTestStatisticButton.UseVisualStyleBackColor = true;
            // 
            // StartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StartUserControl";
            this.Size = new System.Drawing.Size(544, 514);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button StartTestButton;
        private System.Windows.Forms.Button ShowTestStatisticButton;
    }
}

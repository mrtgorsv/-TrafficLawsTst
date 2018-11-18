namespace TrafficLawsTest.Controls
{
    partial class StatisticUserControl
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
            this.StatisticLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.TestStatisticListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.StatisticLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BackButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TestStatisticListBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StatisticLabel
            // 
            this.StatisticLabel.AutoSize = true;
            this.StatisticLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticLabel.Location = new System.Drawing.Point(3, 0);
            this.StatisticLabel.Name = "StatisticLabel";
            this.StatisticLabel.Size = new System.Drawing.Size(554, 29);
            this.StatisticLabel.TabIndex = 0;
            this.StatisticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(3, 348);
            this.BackButton.MaximumSize = new System.Drawing.Size(0, 50);
            this.BackButton.MinimumSize = new System.Drawing.Size(0, 50);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(554, 50);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // TestStatisticListBox
            // 
            this.TestStatisticListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestStatisticListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestStatisticListBox.FormattingEnabled = true;
            this.TestStatisticListBox.ItemHeight = 29;
            this.TestStatisticListBox.Location = new System.Drawing.Point(3, 32);
            this.TestStatisticListBox.Name = "TestStatisticListBox";
            this.TestStatisticListBox.Size = new System.Drawing.Size(554, 310);
            this.TestStatisticListBox.TabIndex = 2;
            // 
            // StatisticUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StatisticUserControl";
            this.Size = new System.Drawing.Size(560, 401);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label StatisticLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox TestStatisticListBox;
    }
}

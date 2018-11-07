namespace TrafficLawsTest.Controls
{
    partial class TestUserControl
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
            this.QuestionOrderLabel = new System.Windows.Forms.Label();
            this.TestImageBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstAnswer = new System.Windows.Forms.RadioButton();
            this.SecondAnswer = new System.Windows.Forms.RadioButton();
            this.ThirdAnswer = new System.Windows.Forms.RadioButton();
            this.FourAnswer = new System.Windows.Forms.RadioButton();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.CompleteTestButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestImageBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.QuestionOrderLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TestImageBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PrevButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CompleteTestButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(592, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // QuestionOrderLabel
            // 
            this.QuestionOrderLabel.AutoSize = true;
            this.QuestionOrderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionOrderLabel.Location = new System.Drawing.Point(3, 0);
            this.QuestionOrderLabel.Name = "QuestionOrderLabel";
            this.QuestionOrderLabel.Size = new System.Drawing.Size(290, 25);
            this.QuestionOrderLabel.TabIndex = 0;
            this.QuestionOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestImageBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TestImageBox, 2);
            this.TestImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestImageBox.Location = new System.Drawing.Point(3, 28);
            this.TestImageBox.Name = "TestImageBox";
            this.TestImageBox.Size = new System.Drawing.Size(586, 269);
            this.TestImageBox.TabIndex = 1;
            this.TestImageBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.FirstAnswer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SecondAnswer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ThirdAnswer, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.FourAnswer, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(586, 114);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // FirstAnswer
            // 
            this.FirstAnswer.AutoSize = true;
            this.FirstAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstAnswer.Location = new System.Drawing.Point(3, 3);
            this.FirstAnswer.Name = "FirstAnswer";
            this.FirstAnswer.Size = new System.Drawing.Size(580, 24);
            this.FirstAnswer.TabIndex = 0;
            this.FirstAnswer.TabStop = true;
            this.FirstAnswer.Tag = 1;
            this.FirstAnswer.UseVisualStyleBackColor = true;
            // 
            // SecondAnswer
            // 
            this.SecondAnswer.AutoSize = true;
            this.SecondAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondAnswer.Location = new System.Drawing.Point(3, 33);
            this.SecondAnswer.Name = "SecondAnswer";
            this.SecondAnswer.Size = new System.Drawing.Size(580, 24);
            this.SecondAnswer.TabIndex = 1;
            this.SecondAnswer.TabStop = true;
            this.SecondAnswer.Tag = 2;
            this.SecondAnswer.UseVisualStyleBackColor = true;
            // 
            // ThirdAnswer
            // 
            this.ThirdAnswer.AutoSize = true;
            this.ThirdAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThirdAnswer.Location = new System.Drawing.Point(3, 63);
            this.ThirdAnswer.Name = "ThirdAnswer";
            this.ThirdAnswer.Size = new System.Drawing.Size(580, 24);
            this.ThirdAnswer.TabIndex = 2;
            this.ThirdAnswer.TabStop = true;
            this.ThirdAnswer.Tag = 3;
            this.ThirdAnswer.UseVisualStyleBackColor = true;
            // 
            // FourAnswer
            // 
            this.FourAnswer.AutoSize = true;
            this.FourAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourAnswer.Location = new System.Drawing.Point(3, 93);
            this.FourAnswer.Name = "FourAnswer";
            this.FourAnswer.Size = new System.Drawing.Size(580, 24);
            this.FourAnswer.TabIndex = 3;
            this.FourAnswer.TabStop = true;
            this.FourAnswer.Tag = 4;
            this.FourAnswer.UseVisualStyleBackColor = true;
            // 
            // PrevButton
            // 
            this.PrevButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrevButton.Location = new System.Drawing.Point(3, 423);
            this.PrevButton.MaximumSize = new System.Drawing.Size(0, 50);
            this.PrevButton.MinimumSize = new System.Drawing.Size(0, 50);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(290, 50);
            this.PrevButton.TabIndex = 3;
            this.PrevButton.Text = "Предыдущий";
            this.PrevButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(299, 423);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(290, 50);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Следующий";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // CompleteTestButton
            // 
            this.CompleteTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompleteTestButton.ForeColor = System.Drawing.Color.Red;
            this.CompleteTestButton.Location = new System.Drawing.Point(439, 3);
            this.CompleteTestButton.MaximumSize = new System.Drawing.Size(150, 25);
            this.CompleteTestButton.MinimumSize = new System.Drawing.Size(150, 25);
            this.CompleteTestButton.Name = "CompleteTestButton";
            this.CompleteTestButton.Size = new System.Drawing.Size(150, 25);
            this.CompleteTestButton.TabIndex = 5;
            this.CompleteTestButton.Text = "Завершить";
            this.CompleteTestButton.UseVisualStyleBackColor = true;
            // 
            // TestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestUserControl";
            this.Size = new System.Drawing.Size(592, 476);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestImageBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label QuestionOrderLabel;
        private System.Windows.Forms.PictureBox TestImageBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton FirstAnswer;
        private System.Windows.Forms.RadioButton SecondAnswer;
        private System.Windows.Forms.RadioButton ThirdAnswer;
        private System.Windows.Forms.RadioButton FourAnswer;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CompleteTestButton;
    }
}

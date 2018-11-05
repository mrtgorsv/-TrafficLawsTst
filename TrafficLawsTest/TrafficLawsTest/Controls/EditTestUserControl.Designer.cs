namespace TrafficLawsTest.Controls
{
    partial class EditTestUserControl
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
            this.QuestionListBox = new System.Windows.Forms.ListBox();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.QuestionGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CorrectAnswerCombobox = new System.Windows.Forms.ComboBox();
            this.FourAnswerTextBox = new System.Windows.Forms.TextBox();
            this.ThirdAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SecondAnswerTextBox = new System.Windows.Forms.TextBox();
            this.QuestionNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstAnswerTextBox = new System.Windows.Forms.TextBox();
            this.QuestionImageBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.QuestionGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.QuestionListBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DownButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.QuestionGroupBox, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // QuestionListBox
            // 
            this.QuestionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionListBox.FormattingEnabled = true;
            this.QuestionListBox.Location = new System.Drawing.Point(3, 3);
            this.QuestionListBox.Name = "QuestionListBox";
            this.tableLayoutPanel1.SetRowSpan(this.QuestionListBox, 2);
            this.QuestionListBox.Size = new System.Drawing.Size(194, 587);
            this.QuestionListBox.TabIndex = 0;
            // 
            // UpButton
            // 
            this.UpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpButton.Location = new System.Drawing.Point(203, 270);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(14, 23);
            this.UpButton.TabIndex = 1;
            this.UpButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(203, 299);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(14, 23);
            this.DownButton.TabIndex = 2;
            this.DownButton.UseVisualStyleBackColor = true;
            // 
            // QuestionGroupBox
            // 
            this.QuestionGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.QuestionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionGroupBox.Location = new System.Drawing.Point(223, 3);
            this.QuestionGroupBox.Name = "QuestionGroupBox";
            this.tableLayoutPanel1.SetRowSpan(this.QuestionGroupBox, 2);
            this.QuestionGroupBox.Size = new System.Drawing.Size(570, 587);
            this.QuestionGroupBox.TabIndex = 3;
            this.QuestionGroupBox.TabStop = false;
            this.QuestionGroupBox.Text = "Редактирование";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.QuestionNameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SecondAnswerTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.CorrectAnswerCombobox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.FourAnswerTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.ThirdAnswerTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.FirstAnswerTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.QuestionImageBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.SaveButton, 1, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(564, 568);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Изображение";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вариант 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вариант 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вариант 3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вариант 4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ответ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CorrectAnswerCombobox
            // 
            this.CorrectAnswerCombobox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CorrectAnswerCombobox.FormattingEnabled = true;
            this.CorrectAnswerCombobox.Location = new System.Drawing.Point(103, 209);
            this.CorrectAnswerCombobox.Name = "CorrectAnswerCombobox";
            this.CorrectAnswerCombobox.Size = new System.Drawing.Size(458, 21);
            this.CorrectAnswerCombobox.TabIndex = 7;
            // 
            // FourAnswerTextBox
            // 
            this.FourAnswerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FourAnswerTextBox.Location = new System.Drawing.Point(103, 170);
            this.FourAnswerTextBox.Name = "FourAnswerTextBox";
            this.FourAnswerTextBox.Size = new System.Drawing.Size(458, 20);
            this.FourAnswerTextBox.TabIndex = 8;
            // 
            // ThirdAnswerTextBox
            // 
            this.ThirdAnswerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ThirdAnswerTextBox.Location = new System.Drawing.Point(103, 130);
            this.ThirdAnswerTextBox.Name = "ThirdAnswerTextBox";
            this.ThirdAnswerTextBox.Size = new System.Drawing.Size(458, 20);
            this.ThirdAnswerTextBox.TabIndex = 9;
            // 
            // SecondAnswerTextBox
            // 
            this.SecondAnswerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecondAnswerTextBox.Location = new System.Drawing.Point(103, 90);
            this.SecondAnswerTextBox.Name = "SecondAnswerTextBox";
            this.SecondAnswerTextBox.Size = new System.Drawing.Size(458, 20);
            this.SecondAnswerTextBox.TabIndex = 10;
            // 
            // QuestionNameTextBox
            // 
            this.QuestionNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuestionNameTextBox.Location = new System.Drawing.Point(103, 10);
            this.QuestionNameTextBox.Name = "QuestionNameTextBox";
            this.QuestionNameTextBox.Size = new System.Drawing.Size(458, 20);
            this.QuestionNameTextBox.TabIndex = 11;
            // 
            // FirstAnswerTextBox
            // 
            this.FirstAnswerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FirstAnswerTextBox.Location = new System.Drawing.Point(103, 50);
            this.FirstAnswerTextBox.Name = "FirstAnswerTextBox";
            this.FirstAnswerTextBox.Size = new System.Drawing.Size(458, 20);
            this.FirstAnswerTextBox.TabIndex = 12;
            // 
            // QuestionImageBox
            // 
            this.QuestionImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionImageBox.Location = new System.Drawing.Point(103, 243);
            this.QuestionImageBox.Name = "QuestionImageBox";
            this.QuestionImageBox.Size = new System.Drawing.Size(458, 282);
            this.QuestionImageBox.TabIndex = 13;
            this.QuestionImageBox.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(103, 531);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(458, 34);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // EditTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditTestUserControl";
            this.Size = new System.Drawing.Size(796, 593);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.QuestionGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox QuestionListBox;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.GroupBox QuestionGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CorrectAnswerCombobox;
        private System.Windows.Forms.TextBox FourAnswerTextBox;
        private System.Windows.Forms.TextBox QuestionNameTextBox;
        private System.Windows.Forms.TextBox SecondAnswerTextBox;
        private System.Windows.Forms.TextBox ThirdAnswerTextBox;
        private System.Windows.Forms.TextBox FirstAnswerTextBox;
        private System.Windows.Forms.PictureBox QuestionImageBox;
        private System.Windows.Forms.Button SaveButton;
    }
}

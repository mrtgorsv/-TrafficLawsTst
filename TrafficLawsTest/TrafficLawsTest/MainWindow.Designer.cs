namespace TrafficLawsTest
{
    partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.AboutTrafficLawsButton = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutPointSystemButton = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutApplicationMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.EditTestButton = new System.Windows.Forms.ToolStripButton();
			this.UserLabel = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.ContentPanel = new System.Windows.Forms.Panel();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.EditTestButton,
            this.UserLabel,
            this.toolStripLabel2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(959, 27);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutTrafficLawsButton,
            this.AboutPointSystemButton,
            this.AboutApplicationMenuButton});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(87, 24);
			this.toolStripDropDownButton1.Text = "Свойства";
			// 
			// AboutTrafficLawsButton
			// 
			this.AboutTrafficLawsButton.Name = "AboutTrafficLawsButton";
			this.AboutTrafficLawsButton.Size = new System.Drawing.Size(223, 26);
			this.AboutTrafficLawsButton.Text = "Что такое ПДД";
			// 
			// AboutPointSystemButton
			// 
			this.AboutPointSystemButton.Name = "AboutPointSystemButton";
			this.AboutPointSystemButton.Size = new System.Drawing.Size(223, 26);
			this.AboutPointSystemButton.Text = "Оценочная система";
			// 
			// AboutApplicationMenuButton
			// 
			this.AboutApplicationMenuButton.Name = "AboutApplicationMenuButton";
			this.AboutApplicationMenuButton.Size = new System.Drawing.Size(223, 26);
			this.AboutApplicationMenuButton.Text = "О программе";
			// 
			// EditTestButton
			// 
			this.EditTestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.EditTestButton.Image = ((System.Drawing.Image)(resources.GetObject("EditTestButton.Image")));
			this.EditTestButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditTestButton.Name = "EditTestButton";
			this.EditTestButton.Size = new System.Drawing.Size(146, 24);
			this.EditTestButton.Text = "Редактировать тест";
			this.EditTestButton.Visible = false;
			// 
			// UserLabel
			// 
			this.UserLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.UserLabel.Name = "UserLabel";
			this.UserLabel.Size = new System.Drawing.Size(0, 24);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(114, 24);
			this.toolStripLabel2.Text = "Пользователь: ";
			// 
			// ContentPanel
			// 
			this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
			this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentPanel.Location = new System.Drawing.Point(0, 27);
			this.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ContentPanel.Name = "ContentPanel";
			this.ContentPanel.Size = new System.Drawing.Size(959, 639);
			this.ContentPanel.TabIndex = 1;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TrafficLawsTest.Properties.Resources.theme;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(959, 666);
			this.Controls.Add(this.ContentPanel);
			this.Controls.Add(this.toolStrip1);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainWindow";
			this.Opacity = 0D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem AboutTrafficLawsButton;
        private System.Windows.Forms.ToolStripMenuItem AboutPointSystemButton;
        private System.Windows.Forms.ToolStripButton EditTestButton;
        private System.Windows.Forms.ToolStripLabel UserLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.ToolStripMenuItem AboutApplicationMenuButton;
    }
}


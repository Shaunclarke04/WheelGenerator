namespace WheelGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubTitle = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripButton1 = new ToolStripButton();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Roboto Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(765, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Wheel Generator";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Dock = DockStyle.Top;
            lblSubTitle.Font = new Font("Roboto Medium", 14F, FontStyle.Bold);
            lblSubTitle.Location = new Point(0, 72);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(765, 26);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Generate Spinny Wheels from Spreadsheets";
            lblSubTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Roboto", 16F);
            groupBox1.Location = new Point(0, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(765, 138);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Source File";
            // 
            // groupBox2
            // 
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Roboto", 16F);
            groupBox2.Location = new Point(0, 236);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(765, 138);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Heading Selection";
            // 
            // groupBox3
            // 
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Roboto", 16F);
            groupBox3.Location = new Point(0, 374);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(765, 138);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Wheel Build";
            // 
            // groupBox4
            // 
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Roboto", 16F);
            groupBox4.Location = new Point(0, 512);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(765, 138);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Export && Spin";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 713);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(765, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(765, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.ic_fluent_dismiss_square_24_filled;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 735);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblSubTitle);
            Controls.Add(lblTitle);
            Controls.Add(toolStrip1);
            MinimumSize = new Size(500, 750);
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubTitle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}

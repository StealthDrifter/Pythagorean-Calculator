namespace WinFormsApp1
{
    partial class TriangleUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleUI));
            groupBox1 = new GroupBox();
            TileHeight = new TextBox();
            TileWidth = new TextBox();
            TileLength = new TextBox();
            groupBox2 = new GroupBox();
            NumberC = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TileHeight);
            groupBox1.Controls.Add(TileWidth);
            groupBox1.Controls.Add(TileLength);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 84);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // TileHeight
            // 
            TileHeight.BackColor = Color.FromArgb(24, 24, 24);
            TileHeight.BorderStyle = BorderStyle.FixedSingle;
            TileHeight.ForeColor = Color.White;
            TileHeight.Location = new Point(6, 47);
            TileHeight.Name = "TileHeight";
            TileHeight.PlaceholderText = "Horizontal Tiles";
            TileHeight.Size = new Size(91, 23);
            TileHeight.TabIndex = 3;
            TileHeight.TextAlign = HorizontalAlignment.Center;
            TileHeight.TextChanged += TileHeight_TextChanged;
            TileHeight.KeyPress += TileHeight_KeyPress;
            // 
            // TileWidth
            // 
            TileWidth.BackColor = Color.FromArgb(24, 24, 24);
            TileWidth.BorderStyle = BorderStyle.FixedSingle;
            TileWidth.ForeColor = Color.White;
            TileWidth.Location = new Point(114, 47);
            TileWidth.Name = "TileWidth";
            TileWidth.PlaceholderText = "Vertical Tiles";
            TileWidth.Size = new Size(91, 23);
            TileWidth.TabIndex = 2;
            TileWidth.TextAlign = HorizontalAlignment.Center;
            TileWidth.TextChanged += TileWidth_TextChanged;
            TileWidth.KeyPress += TileWidth_KeyPress;
            // 
            // TileLength
            // 
            TileLength.BackColor = Color.FromArgb(24, 24, 24);
            TileLength.BorderStyle = BorderStyle.FixedSingle;
            TileLength.ForeColor = Color.White;
            TileLength.Location = new Point(62, 18);
            TileLength.Name = "TileLength";
            TileLength.PlaceholderText = "Tile Length";
            TileLength.Size = new Size(91, 23);
            TileLength.TabIndex = 0;
            TileLength.TextAlign = HorizontalAlignment.Center;
            TileLength.TextChanged += TileLength_TextChanged;
            TileLength.KeyPress += TileLength_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(NumberC);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(211, 63);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output";
            // 
            // NumberC
            // 
            NumberC.BackColor = Color.FromArgb(24, 24, 24);
            NumberC.BorderStyle = BorderStyle.FixedSingle;
            NumberC.Enabled = false;
            NumberC.ForeColor = Color.White;
            NumberC.Location = new Point(6, 22);
            NumberC.Name = "NumberC";
            NumberC.PlaceholderText = "Distance";
            NumberC.ReadOnly = true;
            NumberC.Size = new Size(199, 23);
            NumberC.TabIndex = 0;
            // 
            // TriangleUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(236, 167);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(252, 206);
            MinimumSize = new Size(252, 206);
            Name = "TriangleUI";
            Text = "Triangle Calc";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TileLength;
        private GroupBox groupBox2;
        private TextBox NumberC;
        private TextBox TileHeight;
        private TextBox TileWidth;
    }
}
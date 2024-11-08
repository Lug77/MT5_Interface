namespace GriderLevel_interf
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
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonZero = new Button();
            buttonOut = new Button();
            labelVol = new Label();
            labelPnl = new Label();
            labelPos = new Label();
            labelTp = new Label();
            labelSl = new Label();
            textBoxPos = new TextBox();
            textBoxPnl = new TextBox();
            numericUpDownTp = new NumericUpDown();
            numericUpDownVol = new NumericUpDown();
            numericUpDownSl = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSl).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(buttonZero, 2, 2);
            tableLayoutPanel1.Controls.Add(buttonOut, 3, 2);
            tableLayoutPanel1.Controls.Add(labelVol, 2, 1);
            tableLayoutPanel1.Controls.Add(labelPnl, 2, 0);
            tableLayoutPanel1.Controls.Add(labelPos, 0, 0);
            tableLayoutPanel1.Controls.Add(labelTp, 0, 1);
            tableLayoutPanel1.Controls.Add(labelSl, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxPos, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxPnl, 3, 0);
            tableLayoutPanel1.Controls.Add(numericUpDownTp, 1, 1);
            tableLayoutPanel1.Controls.Add(numericUpDownVol, 3, 1);
            tableLayoutPanel1.Controls.Add(numericUpDownSl, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(480, 257);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonZero
            // 
            buttonZero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonZero.BackColor = Color.OliveDrab;
            buttonZero.Location = new Point(243, 173);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(114, 81);
            buttonZero.TabIndex = 0;
            buttonZero.Text = "ZERO";
            buttonZero.UseVisualStyleBackColor = false;
            // 
            // buttonOut
            // 
            buttonOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonOut.BackColor = Color.OrangeRed;
            buttonOut.Location = new Point(363, 173);
            buttonOut.Name = "buttonOut";
            buttonOut.Size = new Size(114, 81);
            buttonOut.TabIndex = 1;
            buttonOut.Text = "OUT";
            buttonOut.UseVisualStyleBackColor = false;
            // 
            // labelVol
            // 
            labelVol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelVol.AutoSize = true;
            labelVol.Location = new Point(243, 85);
            labelVol.Name = "labelVol";
            labelVol.Size = new Size(114, 85);
            labelVol.TabIndex = 2;
            labelVol.Text = "VOL";
            labelVol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPnl
            // 
            labelPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPnl.AutoSize = true;
            labelPnl.Location = new Point(243, 0);
            labelPnl.Name = "labelPnl";
            labelPnl.Size = new Size(114, 85);
            labelPnl.TabIndex = 3;
            labelPnl.Text = "PNL";
            labelPnl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPos
            // 
            labelPos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPos.AutoSize = true;
            labelPos.Location = new Point(3, 0);
            labelPos.Name = "labelPos";
            labelPos.Size = new Size(114, 85);
            labelPos.TabIndex = 4;
            labelPos.Text = "POS";
            labelPos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTp
            // 
            labelTp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTp.AutoSize = true;
            labelTp.Location = new Point(3, 85);
            labelTp.Name = "labelTp";
            labelTp.Size = new Size(114, 85);
            labelTp.TabIndex = 5;
            labelTp.Text = "TP";
            labelTp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSl
            // 
            labelSl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSl.AutoSize = true;
            labelSl.Location = new Point(3, 170);
            labelSl.Name = "labelSl";
            labelSl.Size = new Size(114, 87);
            labelSl.TabIndex = 6;
            labelSl.Text = "SL";
            labelSl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPos
            // 
            textBoxPos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPos.BackColor = Color.LightGray;
            textBoxPos.Location = new Point(123, 22);
            textBoxPos.Margin = new Padding(3, 22, 3, 3);
            textBoxPos.Name = "textBoxPos";
            textBoxPos.Size = new Size(114, 40);
            textBoxPos.TabIndex = 7;
            textBoxPos.Text = "0";
            textBoxPos.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPnl
            // 
            textBoxPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPnl.BackColor = Color.LightGray;
            textBoxPnl.Location = new Point(363, 22);
            textBoxPnl.Margin = new Padding(3, 22, 3, 3);
            textBoxPnl.MaxLength = 10;
            textBoxPnl.Name = "textBoxPnl";
            textBoxPnl.Size = new Size(114, 40);
            textBoxPnl.TabIndex = 8;
            textBoxPnl.Text = "0";
            textBoxPnl.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDownTp
            // 
            numericUpDownTp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownTp.BackColor = Color.LightGray;
            numericUpDownTp.Location = new Point(123, 107);
            numericUpDownTp.Margin = new Padding(3, 22, 3, 3);
            numericUpDownTp.Name = "numericUpDownTp";
            numericUpDownTp.Size = new Size(114, 40);
            numericUpDownTp.TabIndex = 9;
            numericUpDownTp.TextAlign = HorizontalAlignment.Center;
            numericUpDownTp.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownVol
            // 
            numericUpDownVol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownVol.BackColor = Color.LightGray;
            numericUpDownVol.Location = new Point(363, 107);
            numericUpDownVol.Margin = new Padding(3, 22, 3, 3);
            numericUpDownVol.Name = "numericUpDownVol";
            numericUpDownVol.Size = new Size(114, 40);
            numericUpDownVol.TabIndex = 10;
            numericUpDownVol.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDownSl
            // 
            numericUpDownSl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownSl.Location = new Point(123, 192);
            numericUpDownSl.Margin = new Padding(3, 22, 3, 3);
            numericUpDownSl.Name = "numericUpDownSl";
            numericUpDownSl.Size = new Size(114, 40);
            numericUpDownSl.TabIndex = 11;
            numericUpDownSl.TextAlign = HorizontalAlignment.Center;
            numericUpDownSl.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(480, 257);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GriderLevel";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVol).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonZero;
        private Button buttonOut;
        private Label labelVol;
        private Label labelPnl;
        private Label labelPos;
        private Label labelTp;
        private Label labelSl;
        private TextBox textBoxPos;
        private TextBox textBoxPnl;
        private NumericUpDown numericUpDownTp;
        private NumericUpDown numericUpDownVol;
        private NumericUpDown numericUpDownSl;
    }
}

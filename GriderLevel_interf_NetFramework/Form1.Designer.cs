using System.Drawing;
using System.Windows.Forms;

namespace GriderLevel_interf_NetFramework
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.labelVol = new System.Windows.Forms.Label();
            this.labelPnl = new System.Windows.Forms.Label();
            this.labelPos = new System.Windows.Forms.Label();
            this.labelTp = new System.Windows.Forms.Label();
            this.labelSl = new System.Windows.Forms.Label();
            this.textBoxPos = new System.Windows.Forms.TextBox();
            this.textBoxPnl = new System.Windows.Forms.TextBox();
            this.numericUpDownTp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVol = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSl = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSl)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonZero, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonOut, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelVol, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPnl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPnl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownTp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownVol, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSl, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 257);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonZero
            // 
            this.buttonZero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZero.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonZero.Location = new System.Drawing.Point(243, 173);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(114, 81);
            this.buttonZero.TabIndex = 0;
            this.buttonZero.Text = "ZERO";
            this.buttonZero.UseVisualStyleBackColor = false;
            // 
            // buttonOut
            // 
            this.buttonOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOut.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonOut.Location = new System.Drawing.Point(363, 173);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(114, 81);
            this.buttonOut.TabIndex = 1;
            this.buttonOut.Text = "OUT";
            this.buttonOut.UseVisualStyleBackColor = false;
            // 
            // labelVol
            // 
            this.labelVol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVol.AutoSize = true;
            this.labelVol.Location = new System.Drawing.Point(243, 85);
            this.labelVol.Name = "labelVol";
            this.labelVol.Size = new System.Drawing.Size(114, 85);
            this.labelVol.TabIndex = 2;
            this.labelVol.Text = "VOL";
            this.labelVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPnl
            // 
            this.labelPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPnl.AutoSize = true;
            this.labelPnl.Location = new System.Drawing.Point(243, 0);
            this.labelPnl.Name = "labelPnl";
            this.labelPnl.Size = new System.Drawing.Size(114, 85);
            this.labelPnl.TabIndex = 3;
            this.labelPnl.Text = "PNL";
            this.labelPnl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPos
            // 
            this.labelPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPos.AutoSize = true;
            this.labelPos.Location = new System.Drawing.Point(3, 0);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(114, 85);
            this.labelPos.TabIndex = 4;
            this.labelPos.Text = "POS";
            this.labelPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTp
            // 
            this.labelTp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTp.AutoSize = true;
            this.labelTp.Location = new System.Drawing.Point(3, 85);
            this.labelTp.Name = "labelTp";
            this.labelTp.Size = new System.Drawing.Size(114, 85);
            this.labelTp.TabIndex = 5;
            this.labelTp.Text = "TP";
            this.labelTp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSl
            // 
            this.labelSl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSl.AutoSize = true;
            this.labelSl.Location = new System.Drawing.Point(3, 170);
            this.labelSl.Name = "labelSl";
            this.labelSl.Size = new System.Drawing.Size(114, 87);
            this.labelSl.TabIndex = 6;
            this.labelSl.Text = "SL";
            this.labelSl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPos
            // 
            this.textBoxPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPos.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPos.Location = new System.Drawing.Point(123, 22);
            this.textBoxPos.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.textBoxPos.Name = "textBoxPos";
            this.textBoxPos.Size = new System.Drawing.Size(114, 40);
            this.textBoxPos.TabIndex = 7;
            this.textBoxPos.Text = "0";
            this.textBoxPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPnl
            // 
            this.textBoxPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPnl.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPnl.Location = new System.Drawing.Point(363, 22);
            this.textBoxPnl.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.textBoxPnl.MaxLength = 10;
            this.textBoxPnl.Name = "textBoxPnl";
            this.textBoxPnl.Size = new System.Drawing.Size(114, 40);
            this.textBoxPnl.TabIndex = 8;
            this.textBoxPnl.Text = "0";
            this.textBoxPnl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownTp
            // 
            this.numericUpDownTp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownTp.BackColor = System.Drawing.Color.LightGray;
            this.numericUpDownTp.Location = new System.Drawing.Point(123, 107);
            this.numericUpDownTp.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.numericUpDownTp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTp.Name = "numericUpDownTp";
            this.numericUpDownTp.Size = new System.Drawing.Size(114, 40);
            this.numericUpDownTp.TabIndex = 9;
            this.numericUpDownTp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownVol
            // 
            this.numericUpDownVol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownVol.BackColor = System.Drawing.Color.LightGray;
            this.numericUpDownVol.DecimalPlaces = 2;
            this.numericUpDownVol.Location = new System.Drawing.Point(363, 107);
            this.numericUpDownVol.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.numericUpDownVol.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownVol.Name = "numericUpDownVol";
            this.numericUpDownVol.Size = new System.Drawing.Size(114, 40);
            this.numericUpDownVol.TabIndex = 10;
            this.numericUpDownVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownSl
            // 
            this.numericUpDownSl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSl.Location = new System.Drawing.Point(123, 192);
            this.numericUpDownSl.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.numericUpDownSl.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSl.Name = "numericUpDownSl";
            this.numericUpDownSl.Size = new System.Drawing.Size(114, 40);
            this.numericUpDownSl.TabIndex = 11;
            this.numericUpDownSl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSl.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(480, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GriderLevel";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSl)).EndInit();
            this.ResumeLayout(false);

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
        public decimal NumericUpDownTpValue
        {
            get { return numericUpDownTp.Value; }
            set { numericUpDownTp.Value = value; }
        }
        public decimal NumericUpDownTpIncrement
        {
            get { return numericUpDownTp.Increment; }
            set { numericUpDownTp.Increment = value; }
        }
        private NumericUpDown numericUpDownVol;
        public decimal NumericUpDownVolValue
        {
            get { return numericUpDownVol.Value; }
            set { numericUpDownVol.Value = value; }
        }
        public decimal NumericUpDownVolIncrement
        {
            get { return numericUpDownVol.Increment; }
            set { numericUpDownVol.Increment = value; }
        }
        private NumericUpDown numericUpDownSl;
        public decimal NumericUpDownSlValue
        {
            get { return numericUpDownSl.Value; }
            set { numericUpDownSl.Value = value; }
        }
        public decimal NumericUpDownSlIncrement
        {
            get { return numericUpDownSl.Increment; }
            set { numericUpDownSl.Increment = value; }
        }
    }
}

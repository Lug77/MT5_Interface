namespace MaBotHedgingC_
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
            Quit = new Button();
            Source_load = new GroupBox();
            From_param_EA = new RadioButton();
            From_interface = new RadioButton();
            From_db = new RadioButton();
            Go_form_2 = new Button();
            Name_expert = new Label();
            Source_load.SuspendLayout();
            SuspendLayout();
            // 
            // Quit
            // 
            Quit.BackColor = Color.Red;
            Quit.Location = new Point(360, 10);
            Quit.Name = "Quit";
            Quit.Size = new Size(30, 30);
            Quit.TabIndex = 3;
            Quit.Text = "X";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_click;
            // 
            // Source_load
            // 
            Source_load.Controls.Add(From_param_EA);
            Source_load.Controls.Add(From_interface);
            Source_load.Controls.Add(From_db);
            Source_load.Location = new Point(60, 113);
            Source_load.Name = "Source_load";
            Source_load.Size = new Size(270, 172);
            Source_load.TabIndex = 4;
            Source_load.TabStop = false;
            Source_load.Text = "Источник загрузки параметров";
            // 
            // From_param_EA
            // 
            From_param_EA.Anchor = AnchorStyles.Left;
            From_param_EA.AutoSize = true;
            From_param_EA.Checked = true;
            From_param_EA.Location = new Point(5, 124);
            From_param_EA.Name = "From_param_EA";
            From_param_EA.Size = new Size(213, 25);
            From_param_EA.TabIndex = 2;
            From_param_EA.TabStop = true;
            From_param_EA.Text = "из Параметров советника";
            From_param_EA.UseVisualStyleBackColor = true;
            From_param_EA.CheckedChanged += Check_from_param_ea;
            // 
            // From_interface
            // 
            From_interface.Anchor = AnchorStyles.Left;
            From_interface.AutoSize = true;
            From_interface.Location = new Point(5, 84);
            From_interface.Name = "From_interface";
            From_interface.Size = new Size(136, 25);
            From_interface.TabIndex = 1;
            From_interface.Text = "из Интерфейса";
            From_interface.UseVisualStyleBackColor = true;
            From_interface.CheckedChanged += Check_from_interface;
            // 
            // From_db
            // 
            From_db.Anchor = AnchorStyles.Left;
            From_db.AutoSize = true;
            From_db.Location = new Point(5, 44);
            From_db.Name = "From_db";
            From_db.Size = new Size(140, 25);
            From_db.TabIndex = 0;
            From_db.Text = "из Базы данных";
            From_db.UseVisualStyleBackColor = true;
            From_db.CheckedChanged += Check_from_db;
            // 
            // Go_form_2
            // 
            Go_form_2.BackColor = Color.GreenYellow;
            Go_form_2.Location = new Point(240, 340);
            Go_form_2.Name = "Go_form_2";
            Go_form_2.Size = new Size(150, 50);
            Go_form_2.TabIndex = 5;
            Go_form_2.Text = "Начать работу";
            Go_form_2.UseVisualStyleBackColor = false;
            Go_form_2.Click += Go_form_2_click;
            // 
            // Name_expert
            // 
            Name_expert.AutoSize = true;
            Name_expert.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Name_expert.Location = new Point(59, 33);
            Name_expert.Name = "Name_expert";
            Name_expert.Size = new Size(272, 50);
            Name_expert.TabIndex = 6;
            Name_expert.Text = "MaBotHedging";
            Name_expert.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(400, 400);
            ControlBox = false;
            Controls.Add(Name_expert);
            Controls.Add(Go_form_2);
            Controls.Add(Source_load);
            Controls.Add(Quit);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "MaBotHedging";
            Load += Form1_Load;
            Source_load.ResumeLayout(false);
            Source_load.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Quit;
        private GroupBox Source_load;
        private RadioButton From_param_EA;
        private RadioButton From_interface;
        private RadioButton From_db;
        private Button Go_form_2;
        private Label Name_expert;
    }
}
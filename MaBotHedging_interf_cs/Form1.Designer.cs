using System.Drawing;
using System.Windows.Forms;

namespace MaBotHedging_interf_cs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.Source_load = new System.Windows.Forms.GroupBox();
            this.From_param_EA = new System.Windows.Forms.RadioButton();
            this.From_interface = new System.Windows.Forms.RadioButton();
            this.From_db = new System.Windows.Forms.RadioButton();
            this.Go_form_2 = new System.Windows.Forms.Button();
            this.Name_expert = new System.Windows.Forms.Label();
            this.Source_load.SuspendLayout();
            this.SuspendLayout();
            // 
            // Source_load
            // 
            this.Source_load.Controls.Add(this.From_param_EA);
            this.Source_load.Controls.Add(this.From_interface);
            this.Source_load.Controls.Add(this.From_db);
            this.Source_load.Location = new System.Drawing.Point(60, 113);
            this.Source_load.Name = "Source_load";
            this.Source_load.Size = new System.Drawing.Size(270, 172);
            this.Source_load.TabIndex = 4;
            this.Source_load.TabStop = false;
            this.Source_load.Text = "Источник загрузки параметров";
            // 
            // From_param_EA
            // 
            this.From_param_EA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.From_param_EA.AutoSize = true;
            this.From_param_EA.Checked = true;
            this.From_param_EA.Location = new System.Drawing.Point(5, 124);
            this.From_param_EA.Name = "From_param_EA";
            this.From_param_EA.Size = new System.Drawing.Size(213, 25);
            this.From_param_EA.TabIndex = 2;
            this.From_param_EA.TabStop = true;
            this.From_param_EA.Text = "из Параметров советника";
            this.From_param_EA.UseVisualStyleBackColor = true;
            // 
            // From_interface
            // 
            this.From_interface.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.From_interface.AutoSize = true;
            this.From_interface.Location = new System.Drawing.Point(5, 84);
            this.From_interface.Name = "From_interface";
            this.From_interface.Size = new System.Drawing.Size(136, 25);
            this.From_interface.TabIndex = 1;
            this.From_interface.Text = "из Интерфейса";
            this.From_interface.UseVisualStyleBackColor = true;
            // 
            // From_db
            // 
            this.From_db.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.From_db.AutoSize = true;
            this.From_db.Location = new System.Drawing.Point(5, 44);
            this.From_db.Name = "From_db";
            this.From_db.Size = new System.Drawing.Size(140, 25);
            this.From_db.TabIndex = 0;
            this.From_db.Text = "из Базы данных";
            this.From_db.UseVisualStyleBackColor = true;
            // 
            // Go_form_2
            // 
            this.Go_form_2.BackColor = System.Drawing.Color.GreenYellow;
            this.Go_form_2.Location = new System.Drawing.Point(240, 340);
            this.Go_form_2.Name = "Go_form_2";
            this.Go_form_2.Size = new System.Drawing.Size(150, 50);
            this.Go_form_2.TabIndex = 5;
            this.Go_form_2.Text = "Начать работу";
            this.Go_form_2.UseVisualStyleBackColor = false;
            // 
            // Name_expert
            // 
            this.Name_expert.AutoSize = true;
            this.Name_expert.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Name_expert.Location = new System.Drawing.Point(59, 33);
            this.Name_expert.Name = "Name_expert";
            this.Name_expert.Size = new System.Drawing.Size(272, 50);
            this.Name_expert.TabIndex = 6;
            this.Name_expert.Text = "MaBotHedging";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.Name_expert);
            this.Controls.Add(this.Go_form_2);
            this.Controls.Add(this.Source_load);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MaBotHedging";
            this.Source_load.ResumeLayout(false);
            this.Source_load.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox Source_load;
        private RadioButton From_param_EA;
        private RadioButton From_interface;
        private RadioButton From_db;
        private Button Go_form_2;
        private Label Name_expert;
    }
}



using System.IO;
using System.Windows.Forms;
using System.Drawing; // <-- AGGIUNTA QUESTA RIGA
namespace indovina_il_giorno
{
    partial class Form2
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
            label_status = new Label();
            label1 = new Label();
            btnSave = new Button();
            listBox1 = new ListBox();
            btnPlay = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(150, 118);
            label_status.Name = "label_status";
            label_status.Size = new Size(0, 15);
            label_status.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 70);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 12;
            label1.Text = "Gioca!";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(290, 119);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 83);
            btnSave.TabIndex = 10;
            btnSave.Text = "Aggiorna la Classifica";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(433, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(238, 139);
            listBox1.TabIndex = 9;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(290, 70);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 8;
            btnPlay.Text = "Gioca";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 226);
            Controls.Add(textBox1);
            Controls.Add(label_status);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(listBox1);
            Controls.Add(btnPlay);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_status;
        private Label label1;
        private Button btnSave;
        private ListBox listBox1;
        private Button btnPlay;
        private TextBox textBox1;
    }
}
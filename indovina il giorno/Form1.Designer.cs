using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing; // <-- AGGIUNTA QUESTA RIGA

using Microsoft.VisualBasic.ApplicationServices;

namespace indovina_il_giorno
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
            textBoxUser = new TextBox();
            labelUsername = new Label();
            btnInsertUser = new Button();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(196, 130);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(100, 23);
            textBoxUser.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(56, 133);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(100, 15);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Inserire username";
            // 
            // btnInsertUser
            // 
            btnInsertUser.Location = new Point(341, 125);
            btnInsertUser.Name = "btnInsertUser";
            btnInsertUser.Size = new Size(102, 40);
            btnInsertUser.TabIndex = 2;
            btnInsertUser.Text = "Inserisci Utente e Gioca!";
            btnInsertUser.UseVisualStyleBackColor = true;
            btnInsertUser.Click += btnInsertUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 241);
            Controls.Add(btnInsertUser);
            Controls.Add(labelUsername);
            Controls.Add(textBoxUser);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUser;
        private Label labelUsername;
        private Button btnInsertUser;
    }
}

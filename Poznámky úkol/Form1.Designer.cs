namespace Poznámky_úkol
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.buttonNewNote = new System.Windows.Forms.Button();
            this.upravit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeleteNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.Location = new System.Drawing.Point(0, 0);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(800, 450);
            this.listBoxNotes.TabIndex = 0;
            // 
            // buttonNewNote
            // 
            this.buttonNewNote.Location = new System.Drawing.Point(429, 327);
            this.buttonNewNote.Name = "buttonNewNote";
            this.buttonNewNote.Size = new System.Drawing.Size(75, 23);
            this.buttonNewNote.TabIndex = 1;
            this.buttonNewNote.Text = "Uložit nový";
            this.buttonNewNote.UseVisualStyleBackColor = true;
            this.buttonNewNote.Click += new System.EventHandler(this.buttonNewNote_Click);
            // 
            // upravit
            // 
            this.upravit.Location = new System.Drawing.Point(524, 327);
            this.upravit.Name = "upravit";
            this.upravit.Size = new System.Drawing.Size(75, 23);
            this.upravit.TabIndex = 2;
            this.upravit.Text = "upravit";
            this.upravit.UseVisualStyleBackColor = true;
            this.upravit.Click += new System.EventHandler(this.buttonEditNote_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "náhled";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // buttonDeleteNote
            // 
            this.buttonDeleteNote.Location = new System.Drawing.Point(524, 376);
            this.buttonDeleteNote.Name = "buttonDeleteNote";
            this.buttonDeleteNote.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteNote.TabIndex = 4;
            this.buttonDeleteNote.Text = "smazat";
            this.buttonDeleteNote.UseVisualStyleBackColor = true;
            this.buttonDeleteNote.Click += new System.EventHandler(this.buttonDeleteNote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteNote);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.upravit);
            this.Controls.Add(this.buttonNewNote);
            this.Controls.Add(this.listBoxNotes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.Button buttonNewNote;
        private System.Windows.Forms.Button upravit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeleteNote;
    }
}


using Poznamkovnik;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Poznámky_úkol
{
    public partial class Form1 : Form
    {
        private List<Note> notes;
        private Poznámky_úkol.Form2.Form2 form2;

        public Form1()
        {
            InitializeComponent();
            notes = Data.LoadNotes();
            UpdateNoteList();
        }

        private void UpdateNoteList()
        {
            listBoxNotes.Items.Clear();
            foreach (Note note in notes)
            {
                listBoxNotes.Items.Add(note.Title);
            }
        }

        private void buttonNewNote_Click(object sender, EventArgs e)
        {
            form2 = new Poznámky_úkol.Form2.Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                notes.Add(form2.GetNote());
                UpdateNoteList();
            }
            form2.Dispose();
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex >= 0)
            {
                Note selectedNote = notes[listBoxNotes.SelectedIndex];
                form2 = new Poznámky_úkol.Form2.Form2(selectedNote);

                // Zablokovat možnost úpravy poznámky ve druhém formuláři
                form2.DisableEditing();

                form2.ShowDialog();
                form2.Dispose();
            }
        }

        private void buttonEditNote_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex >= 0)
            {
                Note selectedNote = notes[listBoxNotes.SelectedIndex];
                form2 = new Poznámky_úkol.Form2.Form2(selectedNote);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    notes[listBoxNotes.SelectedIndex] = form2.GetNote();
                    UpdateNoteList();
                }
                form2.Dispose();
            }
        }

        private void buttonDeleteNote_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex >= 0)
            {
                notes.RemoveAt(listBoxNotes.SelectedIndex);
                UpdateNoteList();
            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.SaveNotes(notes);
        }

        
    }
}

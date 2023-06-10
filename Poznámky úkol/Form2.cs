using System;
using System.Windows.Forms;

namespace Poznámky_úkol.Form2
{
    public partial class Form2 : Form
    {
        private Note note;

        public Form2()
        {
            InitializeComponent();
            note = new Note();
        }
        public void DisableEditing()
        {
            
            buttonSave.Enabled = false;
            
        }

        public Form2(Note existingNote)
        {
            InitializeComponent();
            note = existingNote;
            textBoxTitle.Text = note.Title;
            textBoxText.Text = note.Text;
        }

        public Note GetNote()
        {
            return note;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            note.Title = textBoxTitle.Text;
            note.Text = textBoxText.Text;
            DialogResult = DialogResult.OK;
        }
    }
}

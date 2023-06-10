using Poznámky_úkol;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Poznamkovnik
{
    public static class Data
    {
        private const string NotesFilePath = "notes.xml";

        public static List<Note> LoadNotes()
        {
            List<Note> notes;

            if (!File.Exists(NotesFilePath))
            {
                // Pokud soubor neexistuje, vytvořte prázdný seznam poznámek
                notes = new List<Note>();
                SaveNotes(notes); // Uložte prázdný seznam poznámek do souboru
                return notes;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Note>));
            using (FileStream stream = File.OpenRead(NotesFilePath))
            {
                notes = (List<Note>)serializer.Deserialize(stream);
            }

            return notes;
        }

        public static void SaveNotes(List<Note> notes)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Note>));
            using (FileStream stream = File.Create(NotesFilePath))
            {
                serializer.Serialize(stream, notes);
            }
        }
    }
}

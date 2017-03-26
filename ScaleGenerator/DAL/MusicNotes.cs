using System;
using System.Collections.Generic;

namespace ScaleGenerator.DAL
{
    public class MusicalNotesContainer
    {

        List<string> musicalNotes = new List<string> { "A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab" };
        int numberOfNotes = 0;

        public MusicalNotesContainer()
        {
            numberOfNotes = musicalNotes.Count;
        }

        public string getOneWholeNoteUp(string startingNote)
        {
            return getOneHalfNoteUp(getOneHalfNoteUp(startingNote));
        }

        public string getOneHalfNoteUp(string startingNote)
        {
            //Gets the next note above it
            int indexOfStartingNote = musicalNotes.IndexOf(startingNote);
            int indexOfNoteAHalfStepUp = indexOfStartingNote + 1;
            return (indexOfNoteAHalfStepUp == numberOfNotes) ? musicalNotes[indexOfNoteAHalfStepUp] : musicalNotes[0];            
        }
    }
}
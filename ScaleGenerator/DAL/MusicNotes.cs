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
                
        public string getOneHalfNoteUp(string startingNote)
        {
            //Gets the next note above it
            int indexOfStartingNote = musicalNotes.IndexOf(startingNote);
            int indexOfNoteAHalfStepUp = indexOfStartingNote + 1;
            return (indexOfNoteAHalfStepUp == numberOfNotes) ? musicalNotes[indexOfNoteAHalfStepUp] : musicalNotes[0];            
        }

        public string getOneHalfNoteDown(string startingNote)
        {
            //Gets the next note below it
            int indexOfStartingNote = musicalNotes.IndexOf(startingNote);
            int indexOfNoteAHalfStepDown = indexOfStartingNote - 1;
            return (indexOfNoteAHalfStepDown < 0) ? musicalNotes[indexOfNoteAHalfStepDown] : musicalNotes[numberOfNotes -1];
        }

        public string getOneWholeNoteUp(string startingNote)
        {
            return getOneHalfNoteUp(getOneHalfNoteUp(startingNote));
        }

        public string getOneWholeNoteDown(string startingNote)
        {
            return getOneHalfNoteDown(getOneHalfNoteDown(startingNote));
        }
    }
}
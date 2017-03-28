using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScaleGenerator.DAL;
using ScaleGenerator.Model;

namespace ScaleGenerator.BLL
{


    public class ScaleController
    {
        MusicalNotesContainer mN = null;
        public ScaleController()
        {
            MusicalNotesContainer mN = new MusicalNotesContainer();
        }
        public Scale getMajorScale(string key)
        {
            var scale = new Scale();
            scale.First = key;
            scale.Second = GetYWholeStepsUpFromX(key, 1);
            scale.Third = GetYWholeStepsUpFromX(scale.Second, 1);
            scale.Fourth = GetYHalfStepsUpFromX(scale.Third, 1);
            scale.Fifth = GetYWholeStepsUpFromX(scale.Fourth, 1);
            scale.Sixth = GetYWholeStepsUpFromX(scale.Fifth, 1);
            scale.Seventh = GetYHalfStepsUpFromX(scale.Sixth, 1);

            return scale;
        }

        public Scale getMinorScale(string key)
        {
            var scale = new Scale();
            scale.First = key;
            scale.Second = GetYWholeStepsUpFromX(key, 1);
            scale.Third = GetYHalfStepsUpFromX(scale.Second, 1);
            scale.Fourth = GetYWholeStepsUpFromX(scale.Third, 1);
            scale.Fifth = GetYWholeStepsUpFromX(scale.Fourth, 1);
            scale.Sixth = GetYHalfStepsUpFromX(scale.Fifth, 1);
            scale.Seventh = GetYWholeStepsUpFromX(scale.Sixth, 1);

            return scale;
        }

        private string GetYHalfStepsUpFromX(string x, int y)
        {
            string halfStepUp = mN.getOneHalfNoteUp(x);
            if (y == 1)
            {
                return halfStepUp;
            }
            else
            {
                y--;
                GetYHalfStepsUpFromX(halfStepUp, y);
            }
            throw new ArgumentOutOfRangeException("!(y<1)");
        }

        private string GetYWholeStepsUpFromX(string x, int y)
        {
            string wholeStepUp = mN.getOneWholeNoteUp(x);
            if (y == 1)
            {
                return wholeStepUp;
            }
            else
            {
                y--;
                GetYWholeStepsUpFromX(wholeStepUp, y);
            }
            throw new ArgumentOutOfRangeException("!(y<1)");
        }

       
    }
}

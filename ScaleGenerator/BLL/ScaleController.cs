using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScaleGenerator.DAL;

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

        public class Scale
        {
            private string[] _scale = new string[7];

            public string First
            {
                get
                {
                    return scaleArray[0];
                }
                set
                {
                    scaleArray[0] = value;
                }
            }
            public string Second
            {
                get
                {
                    return scaleArray[1];
                }
                set
                {
                    scaleArray[1] = value;
                }
            }
            public string Third
            {
                get
                {
                    return scaleArray[2];
                }
                set
                {
                    scaleArray[2] = value;
                }
            }
            public string Fourth
            {
                get
                {
                    return scaleArray[3];
                }
                set
                {
                    scaleArray[3] = value;
                }
            }
            public string Fifth
            {
                get
                {
                    return scaleArray[4];
                }
                set
                {
                    scaleArray[4] = value;
                }
            }
            public string Sixth
            {
                get
                {
                    return scaleArray[5];
                }
                set
                {
                    scaleArray[5] = value;
                }
            }
            public string Seventh
            {
                get
                {
                    return scaleArray[6];
                }
                set
                {
                    scaleArray[6] = value;
                }
            }

            public string[] scaleArray { get; set; }
        }
    }
}

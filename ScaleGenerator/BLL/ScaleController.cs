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
            scale.I = key;
            scale.ii = mN.getOneWholeNoteUp(key);
            scale.iii = mN.getOneWholeNoteUp(scale.ii);
            scale.IV = mN.getOneHalfNoteUp(scale.iii);
            scale.V = mN.getOneWholeNoteUp(scale.IV);
            scale.vi = mN.getOneWholeNoteUp(scale.V);
            scale.vii = mN.getOneWholeNoteUp(scale.vi);

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
        public class Scale
        {
            private string[] _scale = new string[7];

            public string I
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
            public string ii
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
            public string iii
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
            public string IV
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
            public string V
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
            public string vi
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
            public string vii
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

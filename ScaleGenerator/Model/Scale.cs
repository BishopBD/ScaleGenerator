using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleGenerator.Model
{
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


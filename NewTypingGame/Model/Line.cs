using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypingGame.Model
{
    public class Line
    {
        public string LineString { get; set; }
        public int LineLength { get; set; }

        public Line(string lineString, int lineLength)
        {
            LineString = lineString;
            LineLength = lineLength;
        }
    }
}

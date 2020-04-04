using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBeginner1
{
    public struct ShelvePosition
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public ShelvePosition(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}

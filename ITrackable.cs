using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacoBellParser
{
    public interface ITrackable
    {
        string Name { get; set; }
        Point Location { get; set; }


    }


}

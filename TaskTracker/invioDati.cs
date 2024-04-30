using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    public class invioDati : EventArgs
    {
        public userData user { get; set; }

        public invioDati(userData userSample)
        {
            user = userSample;
        }
    }
}

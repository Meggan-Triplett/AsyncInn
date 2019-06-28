using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        public string Name { get; set; }
        public int Layout { get; set; }
    }

    public enum Layouts
    {
        Studio = 0,
        OneBedroom = 1,
        TwoBedroom = 2,
    }
}

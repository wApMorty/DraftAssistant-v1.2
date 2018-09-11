using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Draft_Assistant
{
    public class Team : List<Champion>
    {
        public int Length { get; internal set; }
    }
}
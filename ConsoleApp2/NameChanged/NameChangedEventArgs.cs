using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    public class NameChangedEventArgs
    {
        public string NewName { get; set; }
        public string OldName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Training.Exceptions
{
    public class DuplicateTitleException:Exception
    {
        public DuplicateTitleException(string message)
           : base(message) { }
    }
}

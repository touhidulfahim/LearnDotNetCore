﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Common.Utilities
{
    public class DateTimeUtility : IDateTimeUtility
    {
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }

    }
}

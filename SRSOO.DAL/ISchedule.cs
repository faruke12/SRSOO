﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRSOO.IDAL
{
    public interface ISchedule
    {
        ScheduleOfClasses GetScheduleOfClasses(string semester);
    }  
}

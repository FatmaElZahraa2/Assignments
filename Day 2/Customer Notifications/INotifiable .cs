﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Notifications
{
    internal interface INotifiable
    {
        void Push();
        void Open();
        void Content(string content);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace JobScheduler.Messages
{
    public class JobStatusMessage : IEvent
    {
        public int MasterJobId { get; set; }
    }
}

﻿using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzNet_Using
{
    public class Trigger
    {
        private IScheduler Start()
        {
            ISchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = factory.GetScheduler().Result;
            if (!scheduler.IsStarted)
                scheduler.Start();
            return scheduler;
        }
        public void TriggerJob()
        {
            IScheduler scheduler = Start();
            IJobDetail job = JobBuilder.Create<Job>().WithIdentity("Job", null).Build();
            ISimpleTrigger simpleTrigger = (ISimpleTrigger)TriggerBuilder.Create().WithIdentity("Job").StartAt(DateTime.UtcNow).WithSimpleSchedule(x => x.WithIntervalInMinutes(5).RepeatForever()).Build();
            scheduler.ScheduleJob(job, simpleTrigger);
        }
    }
}

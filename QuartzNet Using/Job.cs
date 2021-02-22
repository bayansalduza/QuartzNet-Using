using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzNet_Using
{
    public class Job : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Hello");
            return Task.CompletedTask;
        }
    }
}

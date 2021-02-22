using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzNet_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Trigger();
            a.TriggerJob();
            Console.ReadKey();
        }
    }
}

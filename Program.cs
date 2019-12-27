using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Processor celeron = new Processor();
            DataBus data = new DataBus(clock, celeron);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorCS
{
    class DataBus
    {
        private int bus;
        public DataBus(Clock clock, Processor processor)
        {
            
        }
        public int readNumber()
        {
            return Int32.Parse(bus.ToString().Substring(3));
        }
        public int readMantis()
        {
            return Int32.Parse(bus.ToString().Substring(0, 1));
        }
        public int readOrder()
        {
            return Int32.Parse(bus.ToString().Substring(1,2));
        }
        public int readReverseCode()
        {
            return Int32.Parse(bus.ToString().Substring(2,3));
        }
        public int readZero()
        {
            return Int32.Parse(bus.ToString().Substring(3, 4));
        }
        public void write( int word)
        {
            this.bus = word;
        }
    }
}

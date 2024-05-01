using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Memory.Generators
{
    public class IntGenerator : IGenericGenerator<int>
    {
        private int _value;

        public int Next => ++_value;

        public int Current => _value;

        public IntGenerator(int init = 0)
        {
            _value = init;
        }
    }
}

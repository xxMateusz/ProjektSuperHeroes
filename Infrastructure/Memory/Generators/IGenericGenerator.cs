using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Memory.Generators
{
    public interface IGenericGenerator<K>
    {
        K Next { get; }
        K Current { get; }
    }
}

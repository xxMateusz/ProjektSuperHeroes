using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Commons.Repository
{
    public interface IIdentity<K> : IComparable<K> where K : IComparable<K>
    {
        public K Id
        {
            get;
            set;
        }

        int IComparable<K>.CompareTo(K? other)
        {
            return CompareTo(other);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.Entity
{
    public abstract class BaseDbManager
    {
        public abstract void DbConnect(string DbPath);
    }
}

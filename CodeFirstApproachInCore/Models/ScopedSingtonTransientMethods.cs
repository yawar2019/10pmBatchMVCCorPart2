using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproachInCore.Models
{
    public class ScopedSingtonTransientMethods : IScopedSingtonTransientMethods
    {
       Guid NewUser;
        public ScopedSingtonTransientMethods()
        {
             NewUser = Guid.NewGuid();

        }
        public Guid GetScoreResult()
        {
            return NewUser;
        }
    }
}

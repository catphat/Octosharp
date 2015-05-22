using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octosharp.Helpers
{
    public enum PartsEndpoint
    {
        [RequestValue("match")] Match,
        [RequestValue("search")] Search,
        [RequestValue("get_multi")] GetMultiple
    }
}

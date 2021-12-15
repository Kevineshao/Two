using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Two.IDS4
{
    public interface IIDS4Service
    {
        public Task<string> GetIdsTokenAsync(string UserName, string UserPassword);
    }
}

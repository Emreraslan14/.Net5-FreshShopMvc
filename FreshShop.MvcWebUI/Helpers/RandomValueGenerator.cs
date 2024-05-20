using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshShop.MvcWebUI.Helpers
{
    public static class RandomValueGenerator
    {
        public static string GenerateFileName(string extension)
        {
            return Guid.NewGuid().ToString().Replace("-", "") + extension;
        }
    }
}

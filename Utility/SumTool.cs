using System;
using System.Linq;

namespace Utility
{
    public class SumTool
    {
        public int Sum(int[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));

            return values.DefaultIfEmpty().Sum();
        }
    }
}

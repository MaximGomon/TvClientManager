using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWorker
{
    /// <summary>
    /// Параметр сортировки.
    /// </summary>
    public sealed class OredrParam : IMemberCriteria
    {
        public string ProperyName { get; set; }
        public bool IsDesc { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, IsDesc: {1}.", ProperyName, IsDesc);
        }
    }
}

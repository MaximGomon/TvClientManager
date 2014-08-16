using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWorker
{
    public sealed class CriteriaParam : IMemberCriteria
    {
        public string ProperyName { get; set; }
        public string CriteriaValue { get; set; }
        public MemberOperatorType Operator { get; set; }
        public bool IsOperatorAndForSamePropertyName { get; set; }

        public override string ToString()
        {
            return
                string.Format(
                    "{0} {1} {2}, IsOperatorAndForSamePropertyName: {3}.",
                    ProperyName, Operator, CriteriaValue, IsOperatorAndForSamePropertyName);
        }
    }
}

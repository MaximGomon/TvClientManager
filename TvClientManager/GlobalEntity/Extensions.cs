using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GlobalEntity
{
    public static class Extensions
    {
        public static string GetMemberName<T, TValue>(this Expression<Func<T, TValue>> memberSelector)
        {
            if (memberSelector == null)
            {
                throw new ArgumentNullException("memberSelector");
            }
            var memberExpression = memberSelector.Body as MemberExpression;
            if (memberExpression == null)
            {
                throw new NotSupportedException(string.Format("Expression of type {0} not supported.",
                                                              memberSelector.Body.GetType().FullName));
            }
            return memberExpression.Member.Name;
        }
    }
}

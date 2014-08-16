using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWorker
{
    /// <summary>
    /// Операторы поисковых критериев.
    /// </summary>
    public enum MemberOperatorType
    {
        /// <summary>
        /// Равно
        /// </summary>
        IsEqualTo,

        /// <summary>
        /// 
        /// </summary>
        IsNotEqualTo,

        /// <summary>
        /// 
        /// </summary>
        IsLessThan,

        /// <summary>
        /// 
        /// </summary>
        IsLessThanOrEqualTo,

        /// <summary>
        /// 
        /// </summary>
        IsGreaterThanOrEqualTo,

        /// <summary>
        /// 
        /// </summary>
        IsGreaterThan,

        /// <summary>
        /// 
        /// </summary>
        StartsWith,

        /// <summary>
        /// 
        /// </summary>
        EndsWith,

        /// <summary>
        /// 
        /// </summary>
        Contains,

        IsNull,
        IsNotNull
    }
}

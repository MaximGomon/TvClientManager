using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GlobalEntity;

namespace DatabaseWorker
{
    public class QueryParms
    {

        // to delete
        public bool IsViewModel()
        {
            return false;
        }

        public const string ViewModelSuffix = "ViewModel";


        // Fields
        private const string PropertyNameIsDeleted = "IsDelete";
        private readonly List<CriteriaParam> _selectCriterias = new List<CriteriaParam>();
        private readonly List<OredrParam> _oredrParams = new List<OredrParam>();
        private Type _entityType;




        // Constructors
        public QueryParms()
        {
        }

        public QueryParms(Type type)
            : this()
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            TakeCount = int.MaxValue;
            TypeName = type.FullName;

            //var isIDeletable = typeof (IDeletable).IsAssignableFrom(type);
            //if (isIDeletable)
            //{
            //    AddCriteria(PropertyNameIsDeleted, bool.FalseString);
            //}
        }




        // Properties
        /// <summary>
        /// Параметры сортировки.
        /// </summary>
        public List<OredrParam> OredrParams
        {
            get { return _oredrParams; }
        }

        /// <summary>
        /// Список поисковых критериев.
        /// </summary>
        public List<CriteriaParam> SelectCriterias
        {
            get { return _selectCriterias; }
        }

        /// <summary>
        /// Возвращает и задает пропускаемое количество элементов.
        /// Используется для пейджинга.
        /// </summary>
        public int SkipCount { get; set; }

        /// <summary>
        /// Возвращает или задает указанное число элементов.
        /// </summary>
        public int TakeCount { get; set; }

        /// <summary>
        /// Возвращает имя типа, для которого будут создаваться поисковые критерии.
        /// </summary>
        public string TypeName { get; set; }




        // Methods
        /// <summary>
        /// Создает экземпляр параметров запроса для заданного типа.
        /// </summary>
        /// <typeparam name="T">Тип, для которого создается экземпляр параметров запроса.</typeparam>
        /// <returns>Экземпляр параметров запроса для заданного типа.</returns>
        public static QueryParms<T> Create<T>()
        {
            return new QueryParms<T>();
        }

        [Obsolete("Use generic method.", false)]
        protected QueryParms AddCriteria(string member, string value,
                                      MemberOperatorType operatorType = MemberOperatorType.IsEqualTo)
        {
            if (string.IsNullOrWhiteSpace(member))
            {
                throw new ArgumentException("Argument 'member' is null or empty.", "member");
            }


            //if (member == PropertyNameIsDeleted)
            //{
            //    var criteria = _selectCriterias.FirstOrDefault(o => o.ProperyName == PropertyNameIsDeleted);
            //    if (criteria != null)
            //    {
            //        criteria.Operator = operatorType;
            //        criteria.CriteriaValue = value;
            //        return this;
            //    }
            //}


            _selectCriterias.Add(new CriteriaParam
            {
                ProperyName = member,
                Operator = operatorType,
                CriteriaValue = value
            });

            return this;
        }

        [Obsolete("Use generic method.", false)]
        protected QueryParms AddCriteriaIsNull(string member)
        {
            return AddCriteria(member, null, MemberOperatorType.IsNull);
        }

        [Obsolete("Use generic method.", false)]
        protected QueryParms AddCriteriaIsNotNull(string member)
        {
            return AddCriteria(member, null, MemberOperatorType.IsNotNull);
        }

        [Obsolete("Use generic method.", false)]
        protected QueryParms AddCriteriaDate(string member, DateTime dateTime)
        {
            var dFrom = dateTime.Date;
            var dTo = dateTime.Date.AddDays(1).Date;

            return AddCriteriaBetweenDateTime(member, dFrom, dTo);
        }

        [Obsolete("Use generic method.", false)]
        protected QueryParms AddCriteriaBetweenDateTime(string member, DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            if (_selectCriterias.Any(o => o.ProperyName == member))
            {
                throw new ArgumentException(
                    string.Format(
                        "Criteria 'between' must be only one. But property '{0}' has more than one 'between' criteria.",
                        member), member);
            }

            _selectCriterias.Add(new CriteriaParam
            {
                ProperyName = member,
                Operator = MemberOperatorType.IsGreaterThanOrEqualTo,
                CriteriaValue = dateTimeFrom.ToString(CultureInfo.InvariantCulture),
                IsOperatorAndForSamePropertyName = true
            });

            _selectCriterias.Add(new CriteriaParam
            {
                ProperyName = member,
                Operator = MemberOperatorType.IsLessThan,
                CriteriaValue = dateTimeTo.ToString(CultureInfo.InvariantCulture),
                IsOperatorAndForSamePropertyName = true
            });

            return this;
        }

        public QueryParms OrderBy(string member)
        {
            _oredrParams.Add(
                new OredrParam
                {
                    ProperyName = member
                }
                );

            return this;
        }

        public QueryParms OrderByDescending(string member)
        {
            _oredrParams.Add(
                new OredrParam
                {
                    ProperyName = member,
                    IsDesc = true
                }
                );

            return this;
        }

        public QueryParms Skip(int itemsCount)
        {
            if (itemsCount < 0)
            {
                throw new ArgumentOutOfRangeException("itemsCount");
            }

            SkipCount = itemsCount;

            return this;
        }

        public QueryParms Take(int itemsCount)
        {
            if (itemsCount < 1)
            {
                throw new ArgumentOutOfRangeException("itemsCount");
            }

            TakeCount = itemsCount;

            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder().AppendLine("ClientQueryParms:");
            sb.AppendLine(string.Format("TypeName: {0}", TypeName));

            if (_selectCriterias.Any())
            {
                sb.AppendLine("SelectCriterias:");
                foreach (var c in _selectCriterias)
                {
                    sb.AppendLine(c.ToString());
                }
            }
            else
            {
                sb.AppendLine("SelectCriterias: empty");
            }

            if (_oredrParams.Any())
            {
                sb.AppendLine(". OredrParams:");
                foreach (var p in _oredrParams)
                {
                    sb.AppendLine(p.ToString());
                }
            }
            else
            {
                sb.AppendLine(". SelectCriterias: empty");
            }

            sb.Append(string.Format(". SkipCount: {0}", SkipCount));

            sb.Append(string.Format(". TakeCount: {0}", TakeCount));

            return sb.ToString();
        }

        /// <summary>
        /// Возвращает тип для которого созданы параметры запроса.
        /// </summary>
        /// <returns></returns>
        public Type GetEntityType()
        {
            if (_entityType == null)
            {
                if (string.IsNullOrWhiteSpace(TypeName))
                {
                    throw new InvalidOperationException("Property ClientQueryParms.TypeName is empty.");
                }

                var type =
                    AppDomain.CurrentDomain.GetAssemblies()
                             .Where(f => !f.IsDynamic)
                             .SelectMany(f => f.GetTypes())
                             .Single(f => f.FullName == TypeName);

                if (type == null)
                {
                    throw new InvalidOperationException(string.Format("Entity type '{0}' not found.", TypeName));
                }

                _entityType = type;
            }

            return _entityType;
        }

    }

    public class QueryParms<T> : QueryParms
    {
        public QueryParms()
            : base(typeof(T))
        {

        }

        public QueryParms<T> AddCriteria<TValue>(Expression<Func<T, TValue>> memberSelector, TValue value,
                                                 MemberOperatorType operatorType = MemberOperatorType.IsEqualTo)
        {
            AddCriteria(memberSelector.GetMemberName(), string.Format(CultureInfo.InvariantCulture, "{0}", value),
                        operatorType);
            return this;
        }

        public QueryParms<T> AddCriteria<TValue>(Expression<Func<T, TValue>> memberSelector, string value,
                                                 MemberOperatorType operatorType = MemberOperatorType.IsEqualTo)
        {
            AddCriteria(memberSelector.GetMemberName(), string.Format(CultureInfo.InvariantCulture, "{0}", value),
                        operatorType);
            return this;
        }

        public QueryParms<T> AddCriteriaIsNull<TValue>(Expression<Func<T, TValue>> memberSelector)
        {
            AddCriteriaIsNull(memberSelector.GetMemberName());
            return this;
        }

        public QueryParms<T> AddCriteriaIsNotNull<TValue>(Expression<Func<T, TValue>> memberSelector)
        {
            AddCriteriaIsNotNull(memberSelector.GetMemberName());
            return this;
        }

        public QueryParms<T> AddCriteriaDate(Expression<Func<T, DateTime>> memberSelector, DateTime dateTime)
        {
            AddCriteriaDate(memberSelector.GetMemberName(), dateTime);
            return this;
        }

        public QueryParms<T> AddCriteriaDate(Expression<Func<T, DateTime?>> memberSelector, DateTime dateTime)
        {
            AddCriteriaDate(memberSelector.GetMemberName(), dateTime);
            return this;
        }

        public QueryParms<T> AddCriteriaBetweenDateTime(Expression<Func<T, DateTime>> memberSelector,
                                                        DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            AddCriteriaBetweenDateTime(memberSelector.GetMemberName(), dateTimeFrom, dateTimeTo);
            return this;
        }

        public QueryParms<T> AddCriteriaBetweenDateTime(Expression<Func<T, DateTime?>> memberSelector,
                                                        DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            AddCriteriaBetweenDateTime(memberSelector.GetMemberName(), dateTimeFrom, dateTimeTo);
            return this;
        }

        public QueryParms<T> OrderBy<TValue>(Expression<Func<T, TValue>> memberSelector)
        {
            OrderBy(memberSelector.GetMemberName());
            return this;
        }

        public QueryParms<T> OrderByDescending<TValue>(Expression<Func<T, TValue>> memberSelector)
        {
            OrderByDescending(memberSelector.GetMemberName());
            return this;
        }

    }
}

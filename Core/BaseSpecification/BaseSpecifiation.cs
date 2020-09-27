using Core.Specification;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.BaseSpecification
{
    public class BaseSpecifiation<T> : ISpecifiation<T>
    {
        public BaseSpecifiation()
        {

        }
        public BaseSpecifiation(Expression<Func<T,bool>> criteria)
        {
            Criteria = criteria;            
        }
        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        public Expression<Func<T, object>> OrderBy { get; private set; }

        public Expression<Func<T, object>> OrderByDesecending { get; private set; }

        public int Take { get; private set; }

        public int Skip { get; private set; }

        public bool IsPagingEnabled { get; private set; }

        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
        protected void AddOrderBy(Expression<Func<T, object>> OrderByExpression)
        {
            OrderBy = OrderByExpression;
        }
        protected void AddOrderByDesecending(Expression<Func<T, object>> OrderByDescendingExpression)
        {
            OrderByDesecending = OrderByDescendingExpression;
        }

        protected void ApplyPaging(int skip,int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }
    }
}

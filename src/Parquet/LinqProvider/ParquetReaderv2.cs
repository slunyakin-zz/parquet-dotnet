using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Parquet.LinqProvider
{
   class ParquetReaderV2 : IQueryable<Row>, IQueryProvider
   {
      private Expression _expression = null;

      #region [ IQueryable ]

      public Type ElementType => typeof(Row);

      public Expression Expression => Expression.Constant(this);

      public IQueryProvider Provider => this;

      public IEnumerator<Row> GetEnumerator()
      {
         return Provider.Execute<IEnumerator<Row>>(_expression);
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }

      #endregion

      #region [ IQueryProvider ]

      public IQueryable CreateQuery(Expression expression)
      {
         _expression = expression;

         return this;
      }

      public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
      {
         _expression = expression;

         return (IQueryable<TElement>)this;
      }

      public object Execute(Expression expression)
      {
         throw new NotImplementedException();
      }

      public TResult Execute<TResult>(Expression expression)
      {
         throw new NotImplementedException();
      }

      #endregion
   }
}

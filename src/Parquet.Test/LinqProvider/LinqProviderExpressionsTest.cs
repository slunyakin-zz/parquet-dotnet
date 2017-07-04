using Parquet.LinqProvider;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace Parquet.Test.LinqProvider
{
   public class LinqProviderExpressionsTest
   {
      [Fact]
      public void Where_creates_expression()
      {
         var reader = new ParquetReaderV2();

         var query = from r in reader
                     where r.Age < 40
                     select r;
      }
   }
}

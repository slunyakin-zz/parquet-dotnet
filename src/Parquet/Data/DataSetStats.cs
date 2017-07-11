using System;
using System.Collections.Generic;
using System.Text;

namespace Parquet.Data
{
   class DataSetStats
   {
      private readonly DataSet _ds;
      private readonly Dictionary<SchemaElement, ColumnStats> _schemaToStats = new Dictionary<SchemaElement, ColumnStats>();

      struct ColumnStats
      {
         bool HasNulls;
      }

      public DataSetStats(DataSet ds)
      {
         _ds = ds;
      }

      private ColumnStats GetColumnStats(SchemaElement schema)
      {
         if (_schemaToStats.TryGetValue(schema, out ColumnStats result))
            return result;

         CalculateStats(schema);

         return _schemaToStats[schema];
      }

      private void CalculateStats(SchemaElement schema)
      {
         int index = _ds.Schema.GetElementIndex(schema);
      }
   }
}

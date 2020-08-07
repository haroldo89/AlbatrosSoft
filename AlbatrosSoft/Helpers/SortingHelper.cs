using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AlbatrosSoft.Helpers
{
    public sealed class SortingHelper<T>
    {
        private const string SORT_DIRECTION_ASC = "ASC";
        private const string SORT_DIRECTION_DESC = "DESC";

        public static IEnumerable<T> SortBy(IEnumerable<T> dataSource, string sortExpressionString, string sortDirection)
        {
            var datasourceValue = dataSource;
            //switch (sortDirection)
            //{
            //    case SORT_DIRECTION_ASC:
            //        datasourceValue = dataSource.OrderBy();
            //        break;
            //    case SORT_DIRECTION_DESC:
            //        datasourceValue = dataSource.OrderByDescending();
            //        break;
            //    default:
            //        datasourceValue = dataSource.OrderBy()
            //        break;
            //}
            return datasourceValue;
        }
    }
}
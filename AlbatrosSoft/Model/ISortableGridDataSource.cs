using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace AlbatrosSoft.Model
{
    /// <summary>
    /// Interface para implementar en cada uno de los formularios para la paginacion 
    /// y ordenamiento de grids.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISortableGridDataSource<T> where T : class
    {
        string GridViewSortExpression { get; set; }
        string GridViewSortDirection { get; set; }
        string GetSortDirection();
        void SortGridView(GridView gv, GridViewSortEventArgs e, IEnumerable<T> dataSource);
        void ChangeGridViewPageIndex(GridView gv, GridViewPageEventArgs e, IEnumerable<T> dataSource);
        IEnumerable<T> SortDataSource(IEnumerable<T> dataSource, bool isPageChanging);
    }
}
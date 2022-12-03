using X.PagedList;

namespace Dimah.Core.Application.Dtos.Search
{
    public class ListPageModel<Model>
    {
        public IPagedList PagingMetaData { get; set; }
        public IPagedList<Model> GridItemsVM { get; set; }
    }
}

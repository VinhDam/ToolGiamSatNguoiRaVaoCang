using ToolGiamSatNguoiRaVaoCang.Data;

namespace ToolGiamSatNguoiRaVaoCang.DataProvider
{
    public class SearchItemDataProvider : ISearchItemDataProvider
    {
        public List<SearchItem> GenerateSearchItemDatas()
        {
            return new List<SearchItem>()
            {
                new SearchItem()
                {
                    ItemName = new ItemName("Công ty","Company"),
                    ParentName = new ItemName("Danh mục", "Menu"),
                    RootName = new ItemName("","")
                },
                new SearchItem()
                {
                    ItemName = new ItemName("Ca làm việc","Shift"),
                    ParentName = new ItemName("Danh mục", "Menu"),
                    RootName = new ItemName("","")
                },
            };
        }
    }
}

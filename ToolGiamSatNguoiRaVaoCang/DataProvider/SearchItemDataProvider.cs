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
                new SearchItem()
                {
                    ItemName = new ItemName("Loại khu vực","zonetype"),
                    ParentName = new ItemName("Danh mục", "Menu"),
                    RootName = new ItemName("","")
                },
                new SearchItem()
                {
                    ItemName = new ItemName("Khu vực","zone"),
                    ParentName = new ItemName("Danh mục", "Menu"),
                    RootName = new ItemName("","")
                },
                new SearchItem()
                {
                    ItemName = new ItemName("",""),
                    ParentName = new ItemName("Nhân viên", "person"),
                    RootName = new ItemName("","")
                },
                new SearchItem()
                {
                    ItemName = new ItemName("",""),
                    ParentName = new ItemName("Danh mục", "menu"),
                    RootName = new ItemName("","")
                },
            };
        }
    }
}

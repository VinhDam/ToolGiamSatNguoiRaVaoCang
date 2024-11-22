namespace ToolGiamSatNguoiRaVaoCang.Data
{
    public class SearchItem
    {
        public ItemName ItemName { get; set; } = new ItemName();
        public ItemName ParentName { get; set; } = new ItemName();
        public ItemName RootName { get; set; } = new ItemName();
    }
}

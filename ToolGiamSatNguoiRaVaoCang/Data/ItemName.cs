namespace ToolGiamSatNguoiRaVaoCang.Data
{
    public class ItemName
    {
        public string VietName { get; set; } = string.Empty;
        public string EngName { get; set; } = string.Empty;
        public ItemName(string vietName, string engName)
        {
            VietName = vietName;
            EngName = engName;
        }
        public ItemName()
        {
            VietName="";
            EngName="";
        }
    }
}

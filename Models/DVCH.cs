namespace dvhc_wasm.Models
{
    public class DVHCItem
    {

        public string Province { get; set; } = "";
        public string ProvinceType { get; set; } = "";
        public int Code { get; set; } = 0;
        public string District { get; set; } = "";
        public string DistrictType { get; set; } = "";
        public int DistrictCode { get; set; } = 0;
        public string Area { get; set; } = "";
        public double AreaCode { get; set; } = 0;
        public string AreaType { get; set; } = "";

    }
}
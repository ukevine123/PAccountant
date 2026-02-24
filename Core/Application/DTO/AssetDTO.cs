namespace Application.DTO
{
    public class AssetCreateDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
    }
    public class AssetUpdateDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
    }
}
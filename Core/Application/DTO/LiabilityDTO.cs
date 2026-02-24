namespace Application.DTO
{
    public class LiabilityCreateDTO
    {
          public string? Name { get; set; } 
          public string? Type { get; set; } 
          public decimal Value { get; set; } 
    }

    public class LiabilityUpdateDTO
    {
         public string? Name { get; set; } 
          public string? Type { get; set; } 
          public decimal Value { get; set; } 
        
    }
}


namespace Application.DTOs;

public class CreateAccountRequest
{
    public string Name { get; set; } 
    public decimal InitialBalance { get; set; } 
}

public class AccountDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Balance { get; set; }
}

public class AccountCreateDTOs
{
    public string Name { get; set; } = string.Empty;
    public string? Number { get; set; }
    public decimal Balance { get; set; }
}

public class AccountUpdateDTOs
{
    public string Name { get; set; } = string.Empty;
    public string? Number { get; set; }
    public decimal Balance { get; set; }
}

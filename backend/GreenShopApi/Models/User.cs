namespace GreenShopApi.Models;

public partial class User
{
    public int IdUser { get; set; }

    public string Username { get; set; } = null!;

    public string EmailUser { get; set; } = null!;

    public string PasswordUser { get; set; } = null!;
}

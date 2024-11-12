namespace GreenShopApi.DTOs
{
    public class UserDTO
    {
        public int IdUser { get; set; }

        public string Username { get; set; } = null!;

        public string EmailUser { get; set; } = null!;

        public string PasswordUser { get; set; } = null!;
        public string ConfirmPassword { get; set; }
    }
}

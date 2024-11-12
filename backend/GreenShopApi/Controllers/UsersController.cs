using GreenShopApi.DTOs;
using GreenShopApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("{email}/{password}")]
        public ActionResult<User?> GetUser(string email, string password)
        {
            var user = Program.context.Users.FirstOrDefault(u => u.EmailUser == email && u.PasswordUser == password);
            return user == null ? NotFound("Пользователь не найден.") : Ok(user);
        }

        [HttpPost("register")]
        public ActionResult<User> Register([FromBody] UserDTO user)
        {
            var existingUser = Program.context.Users.FirstOrDefault(u => u.EmailUser == user.EmailUser);
            if (existingUser != null) { return Conflict("Пользователь с указанной почтой уже зарегистрирован."); }

            if (user.PasswordUser != user.ConfirmPassword) { return Conflict("Пароли не совпадают."); }

            var newUser = new User
            {
                IdUser = Program.context.Users.Any() ? Program.context.Users.Max(u => u.IdUser) + 1 : 1,
                Username = user.Username,
                EmailUser = user.EmailUser,
                PasswordUser = user.PasswordUser
            };

            Program.context.Users.Add(newUser);
            Program.context.SaveChanges();
            return StatusCode(201, newUser);
        }
    }
}

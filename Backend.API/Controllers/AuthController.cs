using Backend.API.Commands;
using Backend.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Backend.DataAccess.Repositories;
using Backend.Model.Interfaces;

namespace Backend.API.Controllers
{
    [ApiController, Route("api/auth")]
    public class AuthController : ControllerBase
    {
	    private readonly IUserRepository _userRepository;

	    public AuthController(IUserRepository userRepository)
	    {
		    _userRepository = userRepository;
	    }

        [AllowAnonymous, HttpPost("login")]
        public object Authenticate([FromBody]UserCommand userCommand, 
	        [FromServices]AuthTokenService service)
        {
	        var userFound = _userRepository.CheckEmailAndPassAsync(userCommand.Email, userCommand.Password);
	        if (userFound is false)
	        {
		        return BadRequest("You apparently put in the wrong password, or the wrong email. Try again");
	        }

            var claims = new List<Claim>();
            claims.Add(new Claim("username", userCommand.Email));
            claims.Add(new Claim("displayname", userCommand.Email));

            // Add roles as multiple claims
            //foreach(var role in user.Roles) 
            //{
            //    claims.Add(new Claim(ClaimTypes.Role, role.Name));
            //}
            // Optionally add other app specific claims as needed
            claims.Add(new Claim("UserState", "Active"));

            // create a new token with token helper and add our claim
            // from `Westwind.AspNetCore`  NuGet Package
            var token = service.GenerateToken(userCommand.Email, claims.ToArray());

            return new
            {
                access_token = new JwtSecurityTokenHandler().WriteToken(token),
                expires = token.ValidTo
            };
        }
    }
}

using Backend.API.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backend.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
	private readonly UserService _userService;

	public UsersController(UserService userService)
	{
		_userService = userService;
	}

	[AllowAnonymous]
	[HttpGet]
	public async Task<IActionResult> GetAsync()
	{
		return Ok(await _userService.GetUsers());
	}

	[AllowAnonymous]
	[HttpGet("{userId}")]
	public async Task<IActionResult> GetByIdAsync(int userId)
	{
		var userFound = await _userService.GetUserById(userId);
		if (userFound is null) return NotFound($"User with Id: {userId} was not found");
		return Ok(userFound);
	}

	[AllowAnonymous]
	[HttpGet("{userId}/todos")]
	public async Task<IActionResult> GetTodosByUserIdAsync(int userId)
	{
		var todosFound = await _userService.GetTodosByUserId(userId);
		if (todosFound is null) return NotFound($"User with Id: {userId} was not found");
		return Ok(todosFound);
	}

	[AllowAnonymous]
	[HttpGet("{userId}/todos/{todoId}")]
	public async Task<IActionResult> GetTodoByUserIdAsync(int userId, int todoId)
	{
		var todoFound = await _userService.GetTodoByUserAndTodoIdAsync(userId, todoId);
		if (todoFound is null) return NotFound($"Todo with Id: {todoId} was not found for UserId : {userId}");
		return Ok(todoFound);
	}
}
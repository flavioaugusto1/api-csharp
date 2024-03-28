using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Communication.Requests;
using MyFirstAPI.Communication.Responses;

namespace MyFirstAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetUser(int id)
    {
        var response = new User
        {
            Id = 1,
            Name = "Test",
            Age = 26,
        };
        return Ok(response);
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisteredUserJson
        {
            UserId = 1,
            UserName = "Flávio"
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateUser([FromRoute] int id, [FromBody] RequestUpdateUserProfile request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    public  IActionResult DeleteUser([FromRoute] string id)
    {
        return NoContent();
    }
}

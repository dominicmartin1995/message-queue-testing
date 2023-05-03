using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController
{
    [HttpPost]
    public Task Send()
    {
        return Task.CompletedTask;
    }
}

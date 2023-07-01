namespace Starter.Web.Controllers
{
  using Microsoft.AspNetCore.Mvc;

  [Route("api/[controller]")]
  public class PingController : ControllerBase
  {
    private readonly ILogger<PingController> logger;

    public PingController(ILogger<PingController> logger)
    {
      this.logger = logger;
    }

    [HttpGet]
    [Route("Ping")]
    public IActionResult Ping()
    {
      this.logger.LogDebug("Ping received");
      return this.Ok("\"Pong\"");
    }
  }
}

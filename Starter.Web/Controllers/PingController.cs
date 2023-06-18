namespace Starter.Web.Controllers
{
  using Microsoft.AspNetCore.Mvc;
  using Newtonsoft.Json;

  [ApiController]
  [Route("/api/[controller]")]
  public class PingController : ControllerBase
  {
    private readonly ILogger<PingController> logger;

    public PingController(ILogger<PingController> logger)
    {
      this.logger = logger;
    }

    [HttpGet]
    [Route("Ping")]
    public string Ping()
    {
      this.logger.LogDebug("ping received, sending pong");
      return JsonConvert.SerializeObject("Pong");
    }
  }
}

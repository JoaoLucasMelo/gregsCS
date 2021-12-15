using Microsoft.AspNetCore.Mvc;

namespace gregsCS.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class JobsController : ControllerBase
  {
    private readonly JobsService _js;
    public JobsController(JobsService js)
    {
      _js = js;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Job>> Get()
    {
      try
      {
        List<Job> jobs = _js.Get();
        return Ok(jobs);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
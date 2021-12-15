using gregsCS.DB;

namespace gregsCS
{
  public class JobsService
  {
    internal List<Job> Get()
    {
      return FakeDB.Jobs;
    }
  }
}
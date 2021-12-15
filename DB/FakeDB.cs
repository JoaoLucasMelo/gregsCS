

namespace gregsCS.DB
{
  public static class FakeDB
  {
    public static List<Car>? Cars { get; set; } = new List<Car>()
    {
      new Car("X", "Tesla", 2020, 60000, "Black"),
      new Car("Ram 1500", "Dodge", 2011, 13000, "White"),
      new Car("RX-7", "Mazda", 2019, 45000, "Blue")
    };

    public static List<House> Houses { get; set; } = new List<House>()
    {
      new House("123 Street", 1200, 3, 2, 2, 400000),
      new House("3000 Expensive road", 2000, 5, 3, 2, 800000)
    };
    public static List<Job> Jobs { get; set; } = new List<Job>(){
      new Job("Manager", "Target", 40000, "Be a manager at a successful store!"),
            new Job("Software Developer", "HP", 70000, "Be part of the HP team!")
    };
  }
}
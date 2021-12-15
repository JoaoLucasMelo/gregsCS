


namespace gregsCS
{
  public class House
  {

    public string Id { get; set; }
    public string? Address { get; set; }

    public int Size { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Levels { get; set; }
    public int Price { get; set; }


    public House(string? address, int size, int bedrooms, int bathrooms, int levels, int price)
    {
      Id = Guid.NewGuid().ToString();
      Address = address;
      Size = size;
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Levels = levels;
      Price = price;
    }

  }
}
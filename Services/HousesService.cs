using gregsCS.DB;

namespace gregsCS
{
  public class HousesService
  {
    internal List<House> Get()
    {
      return FakeDB.Houses;
    }
    internal House Get(string id)
    {
      House found = FakeDB.Houses.Find(h => h.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid ID");
      }
      return found;
    }
    internal House Create(House newHouse)
    {
      FakeDB.Houses.Add(newHouse);
      return newHouse;
    }
    internal House Update(House updatedHouse)
    {
      House oldHouse = Get(updatedHouse.Id);
      oldHouse.Address = updatedHouse.Address != null ? updatedHouse.Address : oldHouse.Address;
      oldHouse.Bathrooms = updatedHouse.Bathrooms != 0 ? updatedHouse.Bathrooms : oldHouse.Bathrooms;
      oldHouse.Bedrooms = updatedHouse.Bedrooms != 0 ? updatedHouse.Bedrooms : oldHouse.Bedrooms;
      oldHouse.Levels = updatedHouse.Levels != 0 ? updatedHouse.Levels : oldHouse.Levels;
      oldHouse.Price = updatedHouse.Price != 0 ? updatedHouse.Price : oldHouse.Price;
      oldHouse.Size = updatedHouse.Size != 0 ? updatedHouse.Size : oldHouse.Size;
      return oldHouse;
    }
    internal void Remove(string id)
    {
      House house = Get(id);
      FakeDB.Houses.Remove(house);
    }
  }
}
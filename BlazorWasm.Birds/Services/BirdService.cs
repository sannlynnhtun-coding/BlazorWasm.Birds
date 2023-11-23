using Newtonsoft.Json;

namespace BlazorWasm.Birds.Services
{
    public class BirdService
    {
        public List<BirdModel> GetBirds()
        {
            return JsonConvert.DeserializeObject<List<BirdModel>>(BirdData.Birds)!;
        }

        public BirdModel GetBird(int id)
        {
            return GetBirds().FirstOrDefault(x => x.Id == id)!;
        }
    }
}

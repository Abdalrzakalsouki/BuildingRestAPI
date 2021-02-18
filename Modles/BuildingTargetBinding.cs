
namespace BuildingRestAPI.Modles
{
    public class BuildingTargetBinding
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }

        public Building ToBuilding() => new Building()
        {
            Name = this.Name,
            Description = this.Description,
            Number = this.Number,
            Location = this.Location,
            ImageUrl = this.ImageUrl
        };
    }
}

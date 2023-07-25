namespace GameReview_Project.Features.Home
{
    public class Game
    {
        public int Id { get; set; }
        public string Image { get; set; } = "";
        public string Name { get; set; } = "";
        public string Rating { get; set; } = "";
        public string Platforms { get; set; } = "";
        public string Description { get; set; } = "";
        public string Review { get; set; } = "";
 
        //public IEnumerable<RouteInstruction> Route { get; set; } = Array.Empty<RouteInstruction>();
    }

}

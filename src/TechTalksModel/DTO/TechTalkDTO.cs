
namespace TechTalksModel.DTO
{
    public class TechTalkDto
    {
        public int Id { get; set; }
        public string TechTalkName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; }
    }

}
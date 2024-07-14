namespace GameZone.Models
{
    public class Game : BaseEntity
    {
        [MaxLength(2500)]
        public required string Description { get; set; }
        [MaxLength(500)]
        public required string Cover { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!; // initial value
        public ICollection<GameDevice> Devices { get; set; } = new List<GameDevice>();
    }
}

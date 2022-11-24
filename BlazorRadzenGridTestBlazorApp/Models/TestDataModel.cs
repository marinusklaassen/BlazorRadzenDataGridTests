using System.ComponentModel.DataAnnotations;

namespace BlazorRadzenGridTests.BlazorApp.Models
{
    public class TestDataModel
    {
        [Key]
        public int ArtistId { get; set; }
        public string ArtistType { get; set; }
        public string Name { get; set; }
        public bool IsVerified { get; set; }
    }
}

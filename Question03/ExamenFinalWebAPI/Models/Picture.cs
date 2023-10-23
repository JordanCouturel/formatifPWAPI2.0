using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenFinalWebAPI.Models
{
    public class Picture
    {
        public int Id { get; set; }

        public string FileName { get; set; }

        public string MimeType { get; set; }

        [ForeignKey(nameof(Picture))]
        public int VillaId { get; set; }

        public virtual Villa? Villa { get; set; }

    }
}

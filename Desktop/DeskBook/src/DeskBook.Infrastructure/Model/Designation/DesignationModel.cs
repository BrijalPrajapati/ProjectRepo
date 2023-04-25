using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeskBook.Infrastructure.Model.Designation;

[Table("Designation",Schema ="dbo")]
public class DesignationModel
{
    [Key]
    public byte DesignationId { get; set; }
    public string Name { get; set; }
    public short CreatedBy { get; set; }
    public short ModifiedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace DeskBook.AppServices.DTOs.Designation;

public class DesignationResponseDto<T>
{
    public T DesignationId { get; set; }
    public T Name { get; set; }
    public List<string> Error { get; set; }
}

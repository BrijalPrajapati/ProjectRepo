namespace DeskBook.AppServices.DTOs.ResponseDTO;

public class ResponseDto<T>
{
    public T Data { get; set; }
    public List<string> Error { get; set; }
}

namespace EasyForm.Domain.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreateDate { get; set; }
    public string CreateBy { get; set; } = "EasyForm";
    public DateTime? ModifyDate { get; set; }
    public string? ModifyBy { get; set; } = "EasyForm";
}
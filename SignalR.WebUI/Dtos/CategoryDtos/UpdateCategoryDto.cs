namespace SignalR.WebUI.Dtos.CategoryDtos;

public class UpdateCategoryDto
{
	public int CategoryId { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
	public string CategoryName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
	public bool CategoryStatus { get; set; }
}
namespace eLearning.DTO;

public class ProductDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public Rating Rating { get; set; } = new Rating();
}
public class Rating
{
    public decimal Rate { get; set; }
    public int Count { get; set; }
}
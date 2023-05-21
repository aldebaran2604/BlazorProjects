namespace TangyModels.LearnBlazorModels;

public class DemoProduct
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public bool IsActive { get; set; }

    public IEnumerable<DemoProductProp> ProductProperties { get; set; }
}
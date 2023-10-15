namespace TangyModels.LearnBlazorModels;

public class DemoProduct
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public bool IsActive { get; set; }

    public List<DemoProductProp> ProductProperties { get; set; }
}
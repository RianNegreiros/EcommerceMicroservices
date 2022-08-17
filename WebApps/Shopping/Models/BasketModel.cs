namespace Shopping.Models;

public class BasketModel
{
    public string Username { get; set; }
    public List<BasketItemModel> Items { get; set; } = new List<BasketItemModel>();
    public decimal TotalPrice { get; set; }
}
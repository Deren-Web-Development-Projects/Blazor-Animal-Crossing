namespace ClassLibrary.Models
{
    public interface ICreatureModel
    {
        int Id { get; set;}
        string Name { get; set;}
        string Icon { get; set;}
        int SellPrice { get; set;}
        string ShadowSize { get; set;}
        int NorthTimeStart { get; set;}
        int NorthTimeEnd { get; set;}
        int SouthTimeStart { get; set;}
        int SouthTimeEnd { get; set;}
        int NorthMonthStart { get; set;}
        int NorthMonthEnd { get; set;}
        int SouthMonthStart { get; set;}
        int SouthMonthEnd { get; set;}
    }
}
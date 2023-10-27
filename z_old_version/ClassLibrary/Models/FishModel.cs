using System;

namespace ClassLibrary.Models
{
    public class FishModel : IFishModel
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Icon { get; set;}
        public int SellPrice { get; set;}
        public string ShadowSize { get; set;}
        public string Location { get; set;}
        public int NorthTimeStart { get; set;}
        public int NorthTimeEnd { get; set;}
        public int SouthTimeStart { get; set;}
        public int SouthTimeEnd { get; set;}
        public int NorthMonthStart { get; set;}
        public int NorthMonthEnd { get; set;}
        public int SouthMonthStart { get; set;}
        public int SouthMonthEnd { get; set;}
    }
}
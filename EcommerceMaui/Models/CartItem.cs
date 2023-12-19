using CommunityToolkit.Mvvm.ComponentModel;

namespace FruitVegBasket.Models
{
    public partial class CartItem : ObservableObject
    {
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }


        //checks if the amount is being updataed,
        //that's why adding observableproperty and notifyproperty (something should change in the ammount)...
        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        
        private int _quantity;

        public decimal Amount => Price * Quantity;
    }
} 
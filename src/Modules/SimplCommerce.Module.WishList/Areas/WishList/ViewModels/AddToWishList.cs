using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.WishList.Areas.WishList.ViewModels
{
    public class AddToWishList
    {
        [Required]
        public long ProductId { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int Quantity { get; set; }
    }
}

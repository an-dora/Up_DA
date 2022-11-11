using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DoAn2VADT.ViewModels.Book
{
    public class AoU_BookVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} đang trống")]
        [MinLength(3, ErrorMessage = "{0} không được ít hơn {1} ký tự")]
        [MaxLength(250, ErrorMessage = "{0} không được nhiều hơn {1} ký tự")]
        [DisplayName("Tên Sách")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "{0} đang trống")]
        [MinLength(3, ErrorMessage ="{0} không được ít hơn {1} ký tự")]
        [MaxLength(250, ErrorMessage = "{0} không được nhiều hơn {1} ký tự")]
        [DisplayName("Mô tả")]
        public string? Description { get; set; }
        [DisplayName("Hình ảnh")]
        public string? Image { get; set; }
        [DisplayName("Giá")]
        public decimal? Price { get; set; }
        [DisplayName("Giá giảm")]
        public decimal? Discount { get; set; }
    }
}
namespace DeleteMeNow.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Publish On")]
        public DateTime PublishOn { get; set; }

        [Display(Name = "Is Avaliable...?")]
        public bool IsAvaliable { get; set; }

        public decimal Price { get; set; }
    }
}
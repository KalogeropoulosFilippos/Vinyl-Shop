//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShoppingStore.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int OrderId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = " First Name is required")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "A Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Ab Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "An Address is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "A City is required")]
        public string AreaCode { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "A Phone Number is required")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Order Total")]
        public Nullable<decimal> OrderTotal { get; set; }
        [Display(Name = "Order Placed")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> OrderPlaced { get; set; }
        public Nullable<bool> OrderComplete { get; set; }
        [Display(Name = "Order Complete Date")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> OrderCompleteDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
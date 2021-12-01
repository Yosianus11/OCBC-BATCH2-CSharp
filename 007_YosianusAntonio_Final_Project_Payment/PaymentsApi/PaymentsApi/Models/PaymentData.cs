using System;
using System.ComponentModel.DataAnnotations;

namespace PaymentsApi.Models
{
    public class PaymentData
    {
        [Key]
        public int paymentDetailId { get; set; }

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string cardOwnerName { get; set; }

        [StringLength(25, ErrorMessage = "Name cannot be longer than 25 characters.")]
        public string cardNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime expirationDate { get; set; }

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string securityCode { get; set; }
    }
}
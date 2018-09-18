using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    
    [Table("TransactionItem")]

    public class TransactionItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int TransactionId { get; set; }
        [Required]
        public int MovieId { get; set; }

        public TransactionItem() { }

        public TransactionItem(int transactionId, int movieId)
        {
            TransactionId = transactionId;
            MovieId = movieId;
        }
    }
}
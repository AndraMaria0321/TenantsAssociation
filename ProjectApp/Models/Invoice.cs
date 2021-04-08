using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime PayDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ApartmentId { get; set; }

        public Apartment Apartment { get; set; }

    }
}

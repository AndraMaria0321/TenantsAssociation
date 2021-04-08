using ProjectApp.Interfaces;
using ProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Services
{
    public class InvoiceService : IInvoice
    {
        private TenantsContext context;
        public InvoiceService(TenantsContext context)
        {
            this.context = context;
        }

        public void SaveDetails(Invoice invoice)
        {
            int UserId = context.User.ToList().Find(user => user.LastName == invoice.Name).UserId;
            int ApartmentId = context.Apartment.ToList().Find(ap => ap.UserId == UserId).ApartmenTId;
            invoice.ApartmentId = ApartmentId;
            context.Add(invoice);
            context.SaveChanges();
        }

    }
}

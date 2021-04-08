using ProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Interfaces
{
    public interface IInvoice
    {
        void SaveDetails(Invoice invoice);

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Management_Systems
{
    public interface IDataConnection
    {
        CustomerModel CreateCustomer(CusotmerModel model);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Management_Systems
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set;}

        public static void IntializeConnection(bool database , bool textFiles)
        {
            if(database)
            { 
                //TODO create SQL Connection
            }

            if(textFiles)
            {
                //TODO create text connection
            }
        }
    }
}

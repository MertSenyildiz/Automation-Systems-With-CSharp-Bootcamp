using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Core.Events
{
    public enum Action { 
        CREATE=0,
        UPDATE=1,
        PARTIAL_UPDATE=2,
        DELETE=3,
    }
    public delegate void ObjectEventHandler(object sender,object obj,Action action);
}

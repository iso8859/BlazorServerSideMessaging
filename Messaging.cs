using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp6
{
    public class Messaging
    {
        public event Func<string, Task> NewMessageEvent;

        public Task NewMessage(string msg)
        {
            return NewMessageEvent(msg);
        }
    }
}

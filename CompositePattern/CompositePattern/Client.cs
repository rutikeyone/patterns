using System;
using CompositePattern.Components;

namespace CompositePattern
{
    public class Client
    {
        public void ClientCode(Component component)
        {
            component.MobilizationOrder();
        }
    }
}

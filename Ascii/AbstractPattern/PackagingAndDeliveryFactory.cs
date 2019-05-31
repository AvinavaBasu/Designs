using System;

namespace AbstractPattern
{
    public class PackagingAndDeliveryFactory
    {
        internal Packaging CreatePackaging()
        {
            throw new NotImplementedException();
        }

        internal DeliveryDocument CreateDeliveryDocument()
        {
            throw new NotImplementedException();
        }
    }
}
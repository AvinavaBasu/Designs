using System;

namespace AbstractPattern
{
    public class Client
    {
        private Packaging _packaging;
        private DeliveryDocument _deliveryDocument;

        public Client(PackagingAndDeliveryFactory factory)
        {
            _packaging = factory.CreatePackaging();
            _deliveryDocument = factory.CreateDeliveryDocument();

        }

        public Packaging ClientPackaging
        {
            get { return _packaging; } 
        }

        public DeliveryDocument ClientDocumnent
        {
            get { return _deliveryDocument; }
        }

        public abstract class PackAndDeliveryFactory
        {
            public abstract Packaging CreatePackaging();
            public abstract Packaging CreateDeliveryDocument();
        }

        public class StandaryFactory : PackAndDeliveryFactory
        {
            public override Packaging CreateDeliveryDocument()
            {
                return new StandardPackaging();
            }

            public override Packaging CreatePackaging()
            {
                return new Postal();
            }
        }

        public class DelicateFactory : PackAndDeliveryFactory
        {
            public override Packaging CreateDeliveryDocument()
            {
                return new ShockProofPackaging();
            }

            public override Packaging CreatePackaging()
            {
                return new Courier();
            }
        }
    }
}

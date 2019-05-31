using System;

namespace Singleton
{
    public class Singleton
    {
        //has an instance static in nature

        public static Singleton instance = new Singleton();
        //has a property static in nature whcih returns the instance created
        public static Singleton GetInstance { get
            {
                return instance;
            }
        }
        public Singleton()
        {

        }

        // lazy inisialization
        // set the instance to null

        public static Singleton instance2 = null;

        public static Singleton GetInstance2
            {
                get
                {
                if (instance2 == null)
                    instance2 = new Singleton();
                    return instance2;
                }
            }


        //thread-safe doubly checked locking initilization

        public static Singleton instance3 = null;
        private static object lockThis = new object();
        public static  Singleton GetInstance3
        {
            get
            {
                lock (lockThis)
                {
                    if (instance3==null)
                        instance3 = new Singleton();
                        return instance3;
                }
            }
        }


    }
}

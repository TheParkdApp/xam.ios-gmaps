using System;
using System.Collections.Generic;
using System.Text;
using Foundation;

namespace GoogleMapsAPITest.iOS
{
    class NSObjectWrapper : NSObject
    {
        public object Context;

        public NSObjectWrapper(object obj) : base()
        {
            this.Context = obj;
        }

        public static NSObjectWrapper Wrap(object obj)
        {
            return new NSObjectWrapper(obj);
        }
    }
}

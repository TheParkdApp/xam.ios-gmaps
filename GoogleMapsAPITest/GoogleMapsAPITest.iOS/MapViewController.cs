using Foundation;
using System;
using System.Drawing;
using CoreGraphics;
using CoreLocation;
using Google.Maps;
using UIKit;

namespace GoogleMapsAPITest.iOS
{
    public partial class MapViewController : UIViewController
    {
        private MapView mapView;
        
        
        public override void LoadView()
        {
            
            base.LoadView();

            // Create a GMSCameraPosition that tells the map to display the
            // coordinate 37.79,-122.40 at zoom level 6.
            var camera = CameraPosition.FromCamera(33.617272, -111.904907, 15);
            mapView = MapView.FromCamera(CGRect.Empty, camera);
            mapView.MyLocationEnabled = true;

            View = mapView;
            
            var testObj = new MyClass() { TimeSlot = "1:30",SpotsAvailable = 3};
            var testNsObj = NSObjectWrapper.Wrap(testObj);
            var marker = new Marker()
            {
                Title = "GoDaddy",
                UserData = NSObject.FromObject(testNsObj),
                Position = new CLLocationCoordinate2D(33.617272, -111.904907),
                Map = mapView
                    
            };
            //var myObj = testNSObj.Context as MyClass;
            Console.WriteLine(((MyClass)testNsObj.Context).TimeSlot);



        }

        public MapViewController (IntPtr handle) : base (handle)
        {
        }

    }
}


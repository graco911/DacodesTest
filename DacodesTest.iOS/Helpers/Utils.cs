using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace DacodesTest.iOS.Helpers
{
    public static class Utils
    {
        public static NSDate ToNSDate(this DateTime date)
        {
            if (date.Kind == DateTimeKind.Unspecified)
                date = DateTime.SpecifyKind(date, DateTimeKind.Utc);

            return (NSDate)date;
        }
    }
}
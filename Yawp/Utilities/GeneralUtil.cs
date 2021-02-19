using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yawp.Utilities
{
    public static class GeneralUtil
    {
        public static bool HasProperty(object obj, string property) => (obj.GetType().GetProperty(property) != null);

        public static bool HasTimestamps(object obj) => HasProperty(obj, "DateCreated") && HasProperty(obj, "DateModified");

        public static DateTime Now() => DateTime.UtcNow;
    }
}

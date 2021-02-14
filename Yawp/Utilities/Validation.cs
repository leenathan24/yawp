using System;
using System.Text.RegularExpressions;

namespace Yawp.Utilities
{
    public static class ValidationUtil
    {
        public const string EmailAddressRegex = @"[A-Za-z0-9_!#$%&'*+/=?`{|}~^.-]+@[A-Za-z0-9.-]+";

        public const string PhoneNumberRegex = @"\(?[2-9]\d\d\)?[ \-.]?[2-9]\d\d[ \-.]?\d{4}";
    }
}
using System;

namespace FunWithAttr.Attributes
{
    public class CustomAuthorize : Attribute
    {
        private readonly string role;
        public string Role => role;

        public CustomAuthorize(string role)
        {
            this.role = role;
        }
    }
}
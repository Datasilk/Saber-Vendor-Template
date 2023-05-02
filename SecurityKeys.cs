using Saber.Core;
using Saber.Vendor;

namespace Saber.Vendors.Template
{
    public class SecurityKeys : IVendorKeys
    {
        public string Vendor { get; set; } = "Template";
        public SecurityKey[] Keys { get; set; } = new SecurityKey[]
        {
            new SecurityKey(){Value = "view-template-items", Label = "View Template Items", Description = "Allowed to view a list of template items"},
        };
    }
}

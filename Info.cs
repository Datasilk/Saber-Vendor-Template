using Saber.Vendor;
namespace Saber.Vendors.Template
{
    public class Info : IVendorInfo
    {
        public string Key { get; set; } = "Template";
        public string Name { get; set; } = "Template Plugin";
        public string Description { get; set; } = "A template plugin used to show developers how to create their own plugin for Saber";
        public string Icon { get; set; }
        public Vendor.Version Version { get; set; } = "1.0.0.0";
    }
}

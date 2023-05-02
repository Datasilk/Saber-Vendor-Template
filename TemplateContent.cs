using System;
using Saber.Vendor;

namespace Saber.Vendors.Template
{
    public class TemplateContent : Core.Service, IVendorService
    {
        public string GetList()
        {
            if (IsPublicApiRequest || !CheckSecurity("view-template-content")) { return AccessDenied(); }
            try
            {
                var items = Query.MyTable.GetList(User.UserId);
                return JsonResponse(items);
            }
            catch (Exception)
            {
                return Error("Could not retrieve list of template items");
            }
        }
    }
}

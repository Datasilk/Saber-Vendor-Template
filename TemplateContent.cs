using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saber.Core;
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
                var items = Query.MyTable.GetList(request.User.UserId);
                return JsonResponse(datasets.Select(a => new { a.datasetId, a.tableName, a.label, a.partialview, a.description }));
            }
            catch (Exception)
            {
                return Error("Could not retrieve list of Data Sets" + (!string.IsNullOrEmpty(search) ? " using search \"" + search + "\"." : ""));
            }
        }
    }
}

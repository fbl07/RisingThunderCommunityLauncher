using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UpdateServer.Controllers
{
    public class PatchController : ApiController
    {
        public Common.Models.PatchModel GetPatch(int? id = null, string name = null, bool firstPatch = false, bool latestPatch = false)
        {
            Code.DataAccess.Patch patch = null;

            using (var context = new Code.DataAccess.PatchContext())
            {
                if (id.HasValue)
                    patch = context.Patches.FirstOrDefault(x => x.Id == id);

                if (!string.IsNullOrEmpty(name))
                    patch = context.Patches.FirstOrDefault(x => string.Compare(x.Name, name, true) == 0);

                if (firstPatch)
                    patch = context.Patches.FirstOrDefault(x => x.Id == context.Patches.Min(y => y.Id));

                if (latestPatch)
                    patch = context.Patches.FirstOrDefault(x => x.Id == context.Patches.Max(y => y.Id));

                if (patch != null)
                    return new Common.Models.PatchModel() { Id = patch.Id, Name = patch.Name, Date = patch.Date };
                else
                    throw new HttpResponseException(HttpStatusCode.NotFound);

            }
        }


    }
}

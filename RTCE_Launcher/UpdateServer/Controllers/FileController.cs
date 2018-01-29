using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace UpdateServer.Controllers
{
    public class FileController : ApiController
    {
        public IEnumerable<Common.Models.FileModel> Get(string currentPatch)
        {
            using (var context = new Code.DataAccess.PatchContext())
            {
                int? patch = null;

                if (string.IsNullOrEmpty(currentPatch))
                    patch = context.Patches.Min(x => x.Id);
                else if (currentPatch == "-1")
                    patch = -1;
                else
                    patch = context.Patches.FirstOrDefault(x => x.Name == currentPatch).Id;

                if (patch.HasValue)
                    return context.Files.Where(x => x.PatchLastUpdated.Id > patch).ToArray().Select(x => new Common.Models.FileModel() { Id = x.Id, Path = x.Path });
                else
                    throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public IHttpActionResult Get(int id)
        {
            using (var context = new Code.DataAccess.PatchContext())
            {
                var file = context.Files.FirstOrDefault(x => x.Id == id);
                if (file != null)
                {
                    return new Code.FileResult(Path.Combine(HttpContext.Current.Server.MapPath("~\\Files"), file.Path));
                }
                else
                    throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
    }
}

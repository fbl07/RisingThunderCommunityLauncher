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
    public class FilesController : ApiController
    {
        public IEnumerable<Models.FileModel> Get(string currentPatch)
        {
            using (var context = new Code.DataAccess.PatchContext())
            {
                Code.DataAccess.Patch patch;

                if (string.IsNullOrEmpty(currentPatch))
                    patch = context.Patches.FirstOrDefault(x => x.Id == context.Patches.Min(y => y.Id));
                else 
                    patch = context.Patches.FirstOrDefault(x => x.Name == currentPatch);

                if (patch != null)
                    return context.Files.Where(x => x.PatchLastUpdated.Id > patch.Id).ToArray().Select(x => new Models.FileModel() { Id = x.Id, Path = x.Path });
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using eVotingSystem.CORE.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileSystemUploadController : ControllerBase
    {
        [HttpPost]
        public virtual FileDTO Post([FromBody] KeyValuePair<string,byte[]> file)
        {
            string path = null;
            path = Path.Combine(@"Images\ClientImages", Guid.NewGuid().ToString() + file.Key);

            System.IO.File.WriteAllBytes(path,file.Value);
            return new FileDTO() { Name=file.Key, Path=path};
        }
        [HttpGet]
        [Route("GetFile")]
        public virtual byte[] GetFile([FromQuery] string p)
        {
            byte[] o;
            //var a = new System.IO.FileStream(p, System.IO.FileMode.Open);
            //using (FileStream fs = System.IO.File.Open(p, FileMode.Open))
            //{
            //    o = System.IO.File.ReadAllBytes(p);
            //}
            return System.IO.File.ReadAllBytes(p);
        }
    }
}
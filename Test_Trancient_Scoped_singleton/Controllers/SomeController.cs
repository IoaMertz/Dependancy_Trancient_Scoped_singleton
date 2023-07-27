using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test_Trancient_Scoped_singleton.Interfaces;

namespace Test_Trancient_Scoped_singleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeController : ControllerBase
    {
        ITransientService _transientService1;
        ITransientService _transientService2;
        IScopedService _scopedService1;
        IScopedService _scopedService2;
        ISingletonService _singletonService1;
        ISingletonService _singletonService2;

     

        public SomeController(
            ITransientService transientService1,
            ITransientService transientService2,
            IScopedService scopedService1,
            IScopedService scopedService2,
            ISingletonService singletonService1,
            ISingletonService singletonService2) 
        {
            _transientService1 = transientService1;
            _transientService1.Name = "Trans Test1 ";
            _transientService2 = transientService2;
            _transientService2.Name = "Trans Test2 ";
            _scopedService1 = scopedService1;
            _scopedService1.Name = "Scoped Test1 ";
            _scopedService2 = scopedService2;
            _scopedService2.Name = "Scoped Test2 ";
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        [HttpGet]
        public ActionResult<List<string>> GetGuids()
        {
            var List = new List<string>() {
                "_transientService1 "+_transientService1.Name+_transientService1.GetID().ToString(),
                "_transientService2 "+_transientService2.Name+_transientService2.GetID().ToString(),
                "_scopedService1 "+_scopedService1.Name+_scopedService1.GetID().ToString(),
                "_scopedService2 "+_scopedService2.Name+_scopedService2.GetID().ToString(),
                "_singletonService1 "+_singletonService1.GetID().ToString(),
                "_singletonService2 "+_singletonService2.GetID().ToString()

            };
            return List;
        }
    }
}

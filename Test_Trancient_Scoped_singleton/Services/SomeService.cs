using Test_Trancient_Scoped_singleton.Interfaces;

namespace Test_Trancient_Scoped_singleton.Services
{
    public class SomeService :ITransientService,IScopedService,ISingletonService
    {
        Guid id;
        public SomeService()
        {
            id = Guid.NewGuid();
        }

        public string Name { get; set; }

        public Guid GetID()
        {
            return id;
        }
    }
}

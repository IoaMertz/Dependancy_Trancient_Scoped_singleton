namespace Test_Trancient_Scoped_singleton.Interfaces
{
    public interface IScopedService
    {
        Guid GetID();
        string Name { get; set; }
    }
}

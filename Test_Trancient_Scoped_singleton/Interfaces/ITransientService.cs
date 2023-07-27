namespace Test_Trancient_Scoped_singleton.Interfaces
{
    public interface ITransientService
    {
        Guid GetID();
        string Name { get; set; }
    }
}

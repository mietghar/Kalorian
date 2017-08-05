namespace Kalorian.Common.Collections
{
    public class Cl_SexCollection
    {
        public string SexName { get; set; }
        public int Id { get; set; }
        public Cl_SexCollection(string _sexName, int _id)
        {
            SexName = _sexName;
            Id = _id;
        }
    }
}

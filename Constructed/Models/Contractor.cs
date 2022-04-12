namespace Constructed.Models
{
    public class Contractor : Virtual<int>
    {
        public string Name { get; set; }
    }
    public class ContractorJobViewModel : Contractor
    {
        public int JobId { get; set; }
    }
}
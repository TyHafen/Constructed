namespace Constructed.Models
{
    public class Company : Virtual<int>
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    public class CompanyJobViewModel : Company
    {
        public int JobId { get; set; }
    }
}
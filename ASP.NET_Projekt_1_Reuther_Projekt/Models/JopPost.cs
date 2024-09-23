namespace ASP.NET_Projekt_1_Reuther_Projekt.Models
{
    public class JopPost
    {
        public int ID { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string JobLocation { get; set; }
        public int Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string CompanyName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMail  { get; set; }
        public string ContactWebsite { get; set; }
        public byte[] CompanyImage { get; set; }
        public string OwnerUsername { get; set; }
    }
}

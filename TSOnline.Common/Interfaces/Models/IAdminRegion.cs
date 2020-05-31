namespace TSOnline.Common.Interfaces.Models
{
    public interface IAdminRegion
    { 
        string Id { get; set; }

        string Iso3Code { get; }

        string Iso2Code { get; set; }

        string Name { get; set; }
    }
}

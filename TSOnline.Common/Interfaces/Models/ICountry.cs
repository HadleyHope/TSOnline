namespace TSOnline.Common.Interfaces.Models
{
    public interface ICountry
    {
        string Id { get; set; }

        string Iso3Code { get; }

        string Iso2Code { get; set; }

        string Name { get; set; }

        IRegion Region { get; set; }

        IAdminRegion AdminRegion { get; set; }

        IIncomeLevel IncomeLevel { get; set; }

        ILendingType LendingType { get; set; }

        string CapitalCity { get; set; }

        decimal Longitude { get; set; }

        decimal Latitude { get; set; }

        int WitsId { get; set; }

        bool IsReporter { get; set; }

        bool IsPartner { get; set; }
    }
}

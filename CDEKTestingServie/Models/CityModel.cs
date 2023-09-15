namespace CDEKTestingServie.Models
{
    public class CityModel
    {
        public string cityName { get; set; }
        public string cityCode { get; set; }
        public string cityUuid { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string region { get; set; }
        public string regionCode { get; set; }
        public string regionFiasGuid { get; set; }
        public string subRegion { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string kladr { get; set; }
        public string fiasGuid { get; set; }
        public double paymentLimit { get; set; }
        public string timezone { get; set; }

        public CityModel(string cityName, string cityCode, string cityUuid, string country, string countryCode, string region, string regionCode, string regionFiasGuid, string subRegion, double latitude, double longitude, string kladr, string fiasGuid, double paymentLimit, string timezone)
        {
            this.cityName = cityName;
            this.cityCode = cityCode;
            this.cityUuid = cityUuid;
            this.country = country;
            this.countryCode = countryCode;
            this.region = region;
            this.regionCode = regionCode;
            this.regionFiasGuid = regionFiasGuid;
            this.subRegion = subRegion;
            this.latitude = latitude;
            this.longitude = longitude;
            this.kladr = kladr;
            this.fiasGuid = fiasGuid;
            this.paymentLimit = paymentLimit;
            this.timezone = timezone;
        }
        
        public CityModel() { }
    }
}

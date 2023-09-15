namespace CDEKTestingServie.Models
{
    public class ResultDto
    {
        public string price { get; set; }
        public int deliveryPeriodMin { get; set; }
        public int deliveryPeriodMax { get; set; }
        public string deliveryDateMin { get; set; }
        public string deliveryDateMax { get; set; }
        public int tariffId { get; set; }
        public double priceByCurrency { get; set; }
        public string currency { get; set; }
        public int percentVAT { get; set; }
        public List<object> services { get; set; }

        public ResultDto(string price, int deliveryPeriodMin, int deliveryPeriodMax, string deliveryDateMin, string deliveryDateMax, int tariffId, double priceByCurrency, string currency, int percentVAT, List<object> services)
        {
            this.price = price;
            this.deliveryPeriodMin = deliveryPeriodMin;
            this.deliveryPeriodMax = deliveryPeriodMax;
            this.deliveryDateMin = deliveryDateMin;
            this.deliveryDateMax = deliveryDateMax;
            this.tariffId = tariffId;
            this.priceByCurrency = priceByCurrency;
            this.currency = currency;
            this.percentVAT = percentVAT;
            this.services = services;
        }

        public ResultDto() { }
    }
}

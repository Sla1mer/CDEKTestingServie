namespace CDEKTestingServie.Models
{
    public class CalculatePriceCargoDto
    {
        public string senderCityId { get; set; }
        public string receiverCityId { get; set; }
        public string tariffId { get; set; }

        public List<DimensionModel> goods { get; set; }

        public CalculatePriceCargoDto(string senderCityId, string receiverCityId, string tariffId, List<DimensionModel> goods)
        {
            this.senderCityId = senderCityId;
            this.receiverCityId = receiverCityId;
            this.tariffId = tariffId;
            this.goods = goods;
        }

        public CalculatePriceCargoDto() { }
    }
}

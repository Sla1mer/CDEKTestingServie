namespace CDEKTestingServie.Models
{
    public class PriceDto
    {
        public string expressPrice  { get; set; }
        public string regularPrice { get; set; }

        public PriceDto(string expressPrice, string regularPrice)
        {
            this.expressPrice = expressPrice;
            this.regularPrice = regularPrice;
        }

        public PriceDto() { }
    }
}

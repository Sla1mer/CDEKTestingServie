namespace CDEKTestingServie.Models
{
    public class PriceResultDto
    {
        public ResultDto result { get; set; }

        public PriceResultDto(ResultDto result)
        {
            this.result = result;
        }

    }
}

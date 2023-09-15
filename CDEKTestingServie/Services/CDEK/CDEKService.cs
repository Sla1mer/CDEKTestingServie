using CDEKTestingServie.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace CDEKTestingServie.Services.CDEK
{
    public class CDEKService : ICdekService
    {

        private HttpClient httpClient = new HttpClient();
        public async Task<ResponseAnswer<PriceDto>> getPriceDelivery(CargoModel cargoModel)
        {
            string cityCodeDepartures = await getRegionCode(cargoModel.fiasDepartures);
            string cityCodeArrivals = await getRegionCode(cargoModel.fiasArrivals);

            DimensionModel dimensionModel = new DimensionModel(cargoModel.weight, cargoModel.length, cargoModel.width, cargoModel.height);

            List<DimensionModel> dimensionModels = new List<DimensionModel>();
            dimensionModels.Add(dimensionModel);

            CalculatePriceCargoDto calculatePriceExpressCargoDto = new CalculatePriceCargoDto(cityCodeDepartures, cityCodeArrivals, "482", dimensionModels);
            CalculatePriceCargoDto calculatePriceRegularCargoDto = new CalculatePriceCargoDto(cityCodeDepartures, cityCodeArrivals, "483", dimensionModels);

            try
            {
                string expressPrice = await getPrice(calculatePriceExpressCargoDto);
                string regularPrice = await getPrice(calculatePriceRegularCargoDto);
                

                PriceDto priceDto = new PriceDto(expressPrice, regularPrice);

                return new ResponseAnswer<PriceDto>(200, "Стоимость доставки по разным тарифам получена", priceDto);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                return new ResponseAnswer<PriceDto>(500, "Ошибка сервера");
            }
        }


        private async Task<string> getRegionCode(string fiasCode)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"http://integration.cdek.ru/v1/location/cities/json?fiasGuid={fiasCode}");

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                
                List<CityModel> cityModel = JsonConvert.DeserializeObject<List<CityModel>>(responseBody);

                return cityModel[0].cityCode;
            }
            catch (HttpRequestException e)
            {
                return $"Ошибка: {e.Message}";
            }
        }

        private async Task<string> getPrice(CalculatePriceCargoDto calculatePriceCargoDto)
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(calculatePriceCargoDto);

                HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync($"http://api.cdek.ru/calculator/calculate_price_by_json.php", content);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                PriceResultDto resultDto = JsonConvert.DeserializeObject<PriceResultDto>(responseBody);

                return $"Стоимость: {resultDto.result.price} {resultDto.result.currency}";
            }
            catch (HttpRequestException e)
            {
                return $"Ошибка: {e.Message}";
            }
        }
    }
}

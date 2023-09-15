using CDEKTestingServie.Models;


namespace CDEKTestingServie.Services.CDEK
{
    public interface ICdekService
    {
        Task<ResponseAnswer<PriceDto>> getPriceDelivery(CargoModel cargoModel);
    }
}

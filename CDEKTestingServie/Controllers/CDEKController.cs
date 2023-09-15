using CDEKTestingServie.Models;
using CDEKTestingServie.Services.CDEK;
using Microsoft.AspNetCore.Mvc;

namespace CDEKTestingServie.Controllers
{
    [ApiController]
    [Route("/api/cdek")]
    public class CDEKController : ControllerBase
    {
        private CDEKService _CDEKService = new CDEKService();

        [HttpPost]
        [Route("/api/cdek/getPrice")]
        public async Task<ResponseAnswer<PriceDto>> getPrice([FromBody] CargoModel cargoModel)
        {
            return await _CDEKService.getPriceDelivery(cargoModel);
        }
    }
}

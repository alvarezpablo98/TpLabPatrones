using Factory_Method.Repository;
using Microsoft.AspNetCore.Mvc;
using static Factory_Method.DroneAll;

namespace Factory_Method.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly DroneServiceFactory _droneServiceFactory;

        public PedidoController(DroneServiceFactory droneServiceFactory)
        {
            _droneServiceFactory = droneServiceFactory;
        }

        [HttpPost]
        public IActionResult EntregarPedido()
        {
            IDroneService droneService = _droneServiceFactory.CrearDroneService();
            droneService.EntregarPedido();

            return Ok("Pedido entregado con éxito.");
        }
    }
}

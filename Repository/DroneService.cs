namespace Factory_Method.Repository
{
    public class DroneService : IDroneService
    {
        public void EntregarPedido()
        {
            // Lógica para entregar el pedido utilizando los drones
            Console.WriteLine("El drone está entregando el pedido.");
        }
    }
}

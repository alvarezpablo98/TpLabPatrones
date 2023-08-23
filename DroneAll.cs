using Factory_Method.Repository;

namespace Factory_Method
{
    public class DroneAll
    {              

        public class DroneServiceFactory
        {
            public IDroneService CrearDroneService()
            {
                // Lógica para decidir qué tipo de servicio de drones crear
                return new DroneService();
            }
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Otros servicios y configuraciones

            services.AddSingleton<DroneServiceFactory>();
        }
    }
}

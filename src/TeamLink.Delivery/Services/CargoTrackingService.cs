namespace TeamLink.Delivery.Services
{
    public class CargoTrackingService : ICargoTrackingService
    {
        public string GetCargoStatus(string cargoId)
        {
            return "Delivered";
        }
    }
}


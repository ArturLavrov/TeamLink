namespace TeamLink.Delivery.Services
{
    public interface ICargoTrackingService
    {
        public string GetCargoStatus(string cargoId);
    }
}


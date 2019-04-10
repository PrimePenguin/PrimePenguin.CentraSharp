using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Shipment
{
    public class CompleteShipmentFilter : Parameterizable
    {
        [JsonProperty("shipment")] public string Shipment { get; set; }

        [JsonProperty("carrier")] public string Carrier { get; set; }

        [JsonProperty("service")] public string Service { get; set; }

        [JsonProperty("packages")] public int Packages { get; set; }

        [JsonProperty("trackingNumber")] public string TrackingNumber { get; set; }

        [JsonProperty("capture")] public int Capture { get; set; }
    }
}
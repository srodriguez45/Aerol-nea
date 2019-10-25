namespace BLL.Model
{
    public class ModelFlights
    {

        public int idFlight { get; set; }
        public string citySource { get; set; }
        public string cityDestination { get; set; }
        public System.DateTime departureDateTime { get; set; }
        public string planeNumber { get; set; }
        public string pilotName { get; set; }

    }

}

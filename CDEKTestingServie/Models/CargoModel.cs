namespace CDEKTestingServie.Models
{
    public class CargoModel
    {
        public float weight { get; set; }
        public float length { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public string fiasDepartures { get; set; }
        public string fiasArrivals { get; set; }

        public CargoModel(float weight, float length, float width, float height, string fiasDepartures, string fiasArrivals)
        {
            this.weight = weight;
            this.length = length;
            this.width = width;
            this.height = height;
            this.fiasDepartures = fiasDepartures;
            this.fiasArrivals = fiasArrivals;
        }
    }
}

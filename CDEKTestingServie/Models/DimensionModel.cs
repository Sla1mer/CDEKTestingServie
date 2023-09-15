namespace CDEKTestingServie.Models
{
    public class DimensionModel
    {
        public float weight { get; set; }
        public float length { get; set; }
        public float width { get; set; }
        public float height { get; set; }

        public DimensionModel(float weight, float length, float width, float height)
        {
            this.weight = weight / 1000;
            this.length = length / 10;
            this.width = width / 10;
            this.height = height / 10;
        }

        public DimensionModel() { }
    }
}

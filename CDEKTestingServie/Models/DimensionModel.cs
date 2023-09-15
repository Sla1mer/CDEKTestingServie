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
            this.weight = weight;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public DimensionModel() { }
    }
}

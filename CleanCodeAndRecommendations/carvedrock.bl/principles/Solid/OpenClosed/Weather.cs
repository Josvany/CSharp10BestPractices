namespace carvedrock.bl.principles.Solid.OpenClosed
{
    public class Weather
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Description { get; set; }
        public double TemperatureC { get; set; }

        public double TemperatureF
        {
            get { return TemperatureC * 9 / 5 + 32; }
        }

        public float Humidify { get; set; }
        public float Wind { get; set; }
    }
}
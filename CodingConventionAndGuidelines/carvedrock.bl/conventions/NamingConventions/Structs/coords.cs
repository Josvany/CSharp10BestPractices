namespace carvedrock.bl.Conventions.NamingConventions.Structs
{
    public struct Coords
    {
        public double Latitude;
        public double Longitude;

        public override string ToString() => $"Coords({Latitude}, {Longitude})";
    }
}
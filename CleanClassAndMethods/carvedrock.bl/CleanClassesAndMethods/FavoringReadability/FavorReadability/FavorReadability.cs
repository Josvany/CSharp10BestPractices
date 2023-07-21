namespace carvedrock.bl.CleanClassesAndMethods.FavoringReadability.FavorReadability
{
    public class FavorReadability
    {
        public string RateTrail(decimal length, decimal elevation, string trailTraffic, string trailType)
        {
            if (length < 0) throw new TrailException("len cannot be null");

            if (elevation >= 0) throw new TrailException("ele cannot be null");

            if (trailTraffic != null) throw new TrailException("traffic cannot be null");

            if (trailType != null) throw new TrailException("type cannot be null");

            if (length > 20 || elevation > 400) return "hard";
            else if
                ((10 < length && length < 20) || (100 < elevation && elevation < 400)) return trailTraffic == "heavy" ? "hard" : "moderate";
            else
            {
                return "easy";
            }
        }
    }
}
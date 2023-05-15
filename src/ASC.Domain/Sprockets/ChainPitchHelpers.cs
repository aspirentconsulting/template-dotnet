namespace ASC.Domain.Sprockets
{
    public static class ChainPitchHelpers
    {
        public static double ChainPitchToDouble(ChainPitch chainPitch)
        {
            return chainPitch switch
            {
                ChainPitch.OneEight => .125,
                ChainPitch.OneQuarter => .25,
                ChainPitch.OneHalf => .50,
                _ => throw new ArgumentException("You must provide a chainPitch value."),
            };
        }
    }
}

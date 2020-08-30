using System.Collections.Generic;

namespace EUFA
{
    public static class PlayerPosition
    {
        public const string Goalkeeper = "Goalkeeper";

        public const string Defender = "Defender";

        public const string Midfield = "Midfield";

        public const string Forward = "Forward";

        public static readonly IList<string> All = new[] { PlayerPosition.Goalkeeper, PlayerPosition.Defender, PlayerPosition.Midfield, PlayerPosition.Forward };
    }
}

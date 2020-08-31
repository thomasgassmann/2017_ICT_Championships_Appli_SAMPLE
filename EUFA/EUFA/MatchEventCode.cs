using System;

namespace EUFA
{
    public static class MatchEventCode
    {
        public const string Goal = "GOA";
        public const string Foul = "FOU";
        public const string FreeKick = "FRK";
        public const string Corner = "COR";
        public const string Penalty = "PEN";
        public const string Substitute = "SUB";
        public const string YellowCard = "YEL";
        public const string RedCard = "RED";

        public static readonly string[] All = new[]
        {
            MatchEventCode.Goal,
            MatchEventCode.Foul,
            MatchEventCode.FreeKick,
            MatchEventCode.Corner,
            MatchEventCode.Penalty,
            MatchEventCode.Substitute,
            MatchEventCode.YellowCard,
            MatchEventCode.RedCard
        };

        public static string GetDesc(string type)
        {
            switch (type)
            {
                case MatchEventCode.Goal:
                    return "Goal";
                case MatchEventCode.Foul:
                    return "Foul";
                case MatchEventCode.FreeKick:
                    return "Free Kick";
                case MatchEventCode.Corner:
                    return "Corner";
                case MatchEventCode.Penalty:
                    return "Penalty";
                case MatchEventCode.Substitute:
                    return "Substitute";
                case MatchEventCode.YellowCard:
                    return "Yellow card";
                case MatchEventCode.RedCard:
                    return "Red card";
                default:
                    throw new Exception();
            }
        }
    }
}

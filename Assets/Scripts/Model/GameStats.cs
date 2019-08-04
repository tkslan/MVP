using System.Collections.Generic;

namespace Model
{
    public struct GameStats
    {
        public int Score;
        public uint World;
        public uint Level;
        public List<uint> BestLevelTimes;
    }
}
using Microsoft.VisualBasic.ApplicationServices;
using NavalWarfareV3.Entities;

namespace NavalWarfareV3.Entities {

    public class Match
    {
        public int Id;
        public Map? EnemyMap;
        public Map? PlayerMap;
        public User? Player;
        public bool Finished;
    }
}
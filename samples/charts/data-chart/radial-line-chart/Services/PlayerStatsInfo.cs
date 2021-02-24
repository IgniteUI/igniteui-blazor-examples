using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class PlayerStatsInfo
    {
        public string Attribute { get; set; }
        public int RonaldoValue { get; set; }
        public int MessiValue { get; set; }
    }

    public class PlayerStatsData : List<PlayerStatsInfo>
    {
        public PlayerStatsData()
        {
            this.Add(new PlayerStatsInfo() { Attribute = "Dribbling",  RonaldoValue = 8,  MessiValue = 10 });
            this.Add(new PlayerStatsInfo() { Attribute = "Passing",    RonaldoValue = 8,  MessiValue = 10 });
            this.Add(new PlayerStatsInfo() { Attribute = "Finishing",  RonaldoValue = 10, MessiValue = 10 });
            this.Add(new PlayerStatsInfo() { Attribute = "Free Kicks", RonaldoValue = 8,  MessiValue = 9 });
            this.Add(new PlayerStatsInfo() { Attribute = "Penalties",  RonaldoValue = 9,  MessiValue = 7 });
            this.Add(new PlayerStatsInfo() { Attribute = "Physical",   RonaldoValue = 10, MessiValue = 7 });
            this.Add(new PlayerStatsInfo() { Attribute = "Team Play",  RonaldoValue = 7,  MessiValue = 9 });
            this.Add(new PlayerStatsInfo() { Attribute = "Heading",    RonaldoValue = 9,  MessiValue = 6 });
        }
    }
}

using System;
using System.Collections.Generic;
public class RoleplayDataStatsItem
{
    public string Name { get; set; }
    public string Age { get; set; }
    public string Alignment { get; set; }
    public string Race { get; set; }
    public string Class { get; set; }
}

public class RoleplayDataStats
    : List<RoleplayDataStatsItem>
{
    public RoleplayDataStats()
    {
        this.Add(new RoleplayDataStatsItem() { Name = @"Stredo", Age = @"244", Alignment = @"💜 Lawful evil", Race = @"👩 Human", Class = @"🎻 Bard" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Haluun", Age = @"40", Alignment = @"🤍 Unaligned", Race = @"🧒🏻 Hafling", Class = @"🙏🏻 Monk" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Ivellios", Age = @"244", Alignment = @"🧡 Chaotic good", Race = @"👩 Human", Class = @"⚔️ Paladin" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Tes", Age = @"35", Alignment = @"💜 Lawful evil", Race = @"🎭 Changeling", Class = @"🧙‍♂️ Wizard" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Kalla", Age = @"47", Alignment = @"🤎 Neutral evil", Race = @"🤖 Warforged", Class = @"🦹‍♂️ Sorcerer" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Halimath Dundragon", Age = @"149", Alignment = @"🤍 Unaligned", Race = @"🐲 Dragonborn", Class = @"⚔️ Paladin" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Iriphawa", Age = @"39", Alignment = @"💛 Lawful neutral", Race = @"🧝🏻‍♂️ Half-Elf", Class = @"🏹 Ranger" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Quaf", Age = @"25", Alignment = @"💚 Neutral", Race = @"👩 Human", Class = @"🥊 Fighter" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Rat Scratch", Age = @"15", Alignment = @"🤎 Neutral evil", Race = @"🐡 Locathah", Class = @"🍁 Druid" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Slicer", Age = @"57", Alignment = @"💜 Lawful evil", Race = @"🐡 Locathah", Class = @"💪 Barbarian" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Nereones Ahlorsath", Age = @"95", Alignment = @"💛 Lawful neutral", Race = @"👩 Human", Class = @"🥊 Fighter" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Nalvarti Stonecutter", Age = @"118", Alignment = @"❤️ Neutral good", Race = @"🧝‍♀️ Elf", Class = @"❤️‍ Cleric" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Errk", Age = @"22", Alignment = @"🤎 Neutral evil", Race = @"🧝🏻‍♂️ Half-Elf", Class = @"🎻 Bard" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Seven Thundercloud", Age = @"43", Alignment = @"💖 Lawful good", Race = @"🐡 Locathah", Class = @"⚔️ Paladin" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Navarra Chergoba", Age = @"16", Alignment = @"💜 Lawful evil", Race = @"🐯 Tabaxi", Class = @"❤️‍ Cleric" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Sail Snap", Age = @"56", Alignment = @"💖 Lawful good", Race = @"🌳 Arboren", Class = @"💪 Barbarian" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Urreek", Age = @"17", Alignment = @"💜 Lawful evil", Race = @"🧝🏻‍♂️ Half-Elf", Class = @"🐉 Warlock" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Morkral Firetamer", Age = @"24", Alignment = @"🤎 Neutral evil", Race = @"🐲 Dragonborn", Class = @"🙏🏻 Monk" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Vithka", Age = @"53", Alignment = @"💜 Lawful evil", Race = @"🐡 Locathah", Class = @"⚔️ Paladin" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Sandrue Avhoste", Age = @"19", Alignment = @"💙 Chaotic Neutral", Race = @"🐲 Dragonborn", Class = @"🗡️ Rogue" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Hapah Moq", Age = @"34", Alignment = @"💜 Lawful evil", Race = @"🎅🏽 Dwarf", Class = @"🎻 Bard" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Kothar ", Age = @"55", Alignment = @"🤍 Unaligned", Race = @"🧝🏻‍♂️ Half-Elf", Class = @"🐉 Warlock" });
        this.Add(new RoleplayDataStatsItem() { Name = @"Senen", Age = @"40", Alignment = @"💜 Lawful evil", Race = @"🧒🏻 Hafling", Class = @"🥊 Fighter" });
    }
}

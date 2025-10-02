using System;
using System.Collections.Generic;
public class RoleplayTreeGridDataItem
{
    public double ID { get; set; }
    public double ParentID { get; set; }
    public string Name { get; set; }
    public string Age { get; set; }
    public string Alignment { get; set; }
    public string Race { get; set; }
    public string Class { get; set; }
}

public class RoleplayTreeGridData
    : List<RoleplayTreeGridDataItem>
{
    public RoleplayTreeGridData()
    {
        this.Add(new RoleplayTreeGridDataItem() { ID = 1, ParentID = 8, Name = @"Stredo", Age = @"244", Alignment = @"💜 Lawful evil", Race = @"👩 Human", Class = @"🎻 Bard" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 2, ParentID = 7, Name = @"Haluun", Age = @"40", Alignment = @"🤍 Unaligned", Race = @"🧒🏻 Hafling", Class = @"🙏🏻 Monk" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 3, ParentID = 9, Name = @"Ivellios", Age = @"244", Alignment = @"🧡 Chaotic good", Race = @"👩 Human", Class = @"⚔️ Paladin" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 4, ParentID = -1, Name = @"Tes", Age = @"35", Alignment = @"💜 Lawful evil", Race = @"🎭 Changeling", Class = @"🧙‍♂️ Wizard" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 5, ParentID = 3, Name = @"Kalla", Age = @"47", Alignment = @"🤎 Neutral evil", Race = @"🤖 Warforged", Class = @"🦹‍♂️ Sorcerer" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 6, ParentID = 2, Name = @"Halimath Dundragon", Age = @"149", Alignment = @"🤍 Unaligned", Race = @"🐲 Dragonborn", Class = @"⚔️ Paladin" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 7, ParentID = 5, Name = @"Iriphawa", Age = @"39", Alignment = @"💛 Lawful neutral", Race = @"🧝🏻‍♂️ Half-Elf", Class = @"🏹 Ranger" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 8, ParentID = 6, Name = @"Quaf", Age = @"25", Alignment = @"💚 Neutral", Race = @"👩 Human", Class = @"🥊 Fighter" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 9, ParentID = 10, Name = @"Rat Scratch", Age = @"15", Alignment = @"🤎 Neutral evil", Race = @"🐡 Locathah", Class = @"🍁 Druid" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 10, ParentID = 4, Name = @"Slicer", Age = @"57", Alignment = @"💜 Lawful evil", Race = @"🐡 Locathah", Class = @"💪 Barbarian" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 11, ParentID = 7, Name = @"Nereones Ahlorsath", Age = @"95", Alignment = @"💛 Lawful neutral", Race = @"👩 Human", Class = @"🥊 Fighter" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 12, ParentID = 9, Name = @"Nalvarti Stonecutter", Age = @"118", Alignment = @"❤️ Neutral good", Race = @"🧝‍♀️ Elf", Class = @"❤️‍ Cleric" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 13, ParentID = 1, Name = @"Errk", Age = @"22", Alignment = @"🤎 Neutral evil", Race = @"🧝🏻‍♂️ Half-Elf", Class = @"🎻 Bard" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 14, ParentID = 5, Name = @"Seven Thundercloud", Age = @"43", Alignment = @"💖 Lawful good", Race = @"🐡 Locathah", Class = @"⚔️ Paladin" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 15, ParentID = 10, Name = @"Navarra Chergoba", Age = @"16", Alignment = @"💜 Lawful evil", Race = @"🐯 Tabaxi", Class = @"❤️‍ Cleric" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 16, ParentID = 4, Name = @"Sail Snap", Age = @"56", Alignment = @"💖 Lawful good", Race = @"🌳 Arboren", Class = @"💪 Barbarian" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 17, ParentID = 8, Name = @"Urreek", Age = @"17", Alignment = @"💜 Lawful evil", Race = @"🧝🏻‍♂️ Half-Elf", Class = @"🐉 Warlock" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 18, ParentID = 6, Name = @"Morkral Firetamer", Age = @"24", Alignment = @"🤎 Neutral evil", Race = @"🐲 Dragonborn", Class = @"🙏🏻 Monk" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 19, ParentID = 2, Name = @"Vithka", Age = @"53", Alignment = @"💜 Lawful evil", Race = @"🐡 Locathah", Class = @"⚔️ Paladin" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 20, ParentID = 7, Name = @"Sandrue Avhoste", Age = @"19", Alignment = @"💙 Chaotic Neutral", Race = @"🐲 Dragonborn", Class = @"🗡️ Rogue" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 21, ParentID = 8, Name = @"Hapah Moq", Age = @"34", Alignment = @"💜 Lawful evil", Race = @"🎅🏽 Dwarf", Class = @"🎻 Bard" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 22, ParentID = 5, Name = @"Kothar", Age = @"55", Alignment = @"🤍 Unaligned", Race = @"🧝🏻‍♂️ Half-Elf", Class = @"🐉 Warlock" });
        this.Add(new RoleplayTreeGridDataItem() { ID = 23, ParentID = 1, Name = @"Senen", Age = @"40", Alignment = @"💜 Lawful evil", Race = @"🧒🏻 Hafling", Class = @"🥊 Fighter" });
    }
}

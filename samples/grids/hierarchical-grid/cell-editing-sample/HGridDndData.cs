using System;
using System.Collections.Generic;
public class HGridDndDataItem
{
    public string Name { get; set; }
    public string Age { get; set; }
    public string Alignment { get; set; }
    public string Race { get; set; }
    public string Class { get; set; }
    public List<HGridDndDataItem_SkillsItem> Skills { get; set; }
}
public class HGridDndDataItem_SkillsItem
{
    public string Skill { get; set; }
    public string Level { get; set; }
}

public class HGridDndData
    : List<HGridDndDataItem>
{
    public HGridDndData()
    {
        this.Add(new HGridDndDataItem()
        {
            Name = @"Stredo",
            Age = @"244",
            Alignment = @"💜 Lawful evil",
            Race = @"👩 Human",
            Class = @"🎻 Bard",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Bardic Inspiration",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Countercharm",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Jack of All Trades",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Song of Rest",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Haluun",
            Age = @"40",
            Alignment = @"🤍 Unaligned",
            Race = @"🧒🏻 Hafling",
            Class = @"🙏🏻 Monk",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🙏🏻 Unarmored Defense",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🙏🏻 Martial Arts",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🙏🏻 Ki",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🙏🏻 Deflect Missiles",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Ivellios",
            Age = @"244",
            Alignment = @"🧡 Chaotic good",
            Race = @"👩 Human",
            Class = @"⚔️ Paladin",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Divine Sense",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Lay on Hands",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Divine Smite",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Aura of Protection",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Tes",
            Age = @"35",
            Alignment = @"💜 Lawful evil",
            Race = @"🎭 Changeling",
            Class = @"🧙‍♂️ Wizard",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🧙‍♂️ Arcane Recovery",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🧙‍♂️ Arcane Tradition",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🧙‍♂️ Spell Mastery",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🧙‍♂️ Signature Spell",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Kalla",
            Age = @"47",
            Alignment = @"🤎 Neutral evil",
            Race = @"🤖 Warforged",
            Class = @"🦹‍♂️ Sorcerer",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🦹‍♂️ Sorcerous Origin",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🦹‍♂️ Font of Magic",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🦹‍♂️ Metamagic",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🦹‍♂️ Sorcerous Restoration",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Halimath Dundragon",
            Age = @"149",
            Alignment = @"🤍 Unaligned",
            Race = @"🐲 Dragonborn",
            Class = @"⚔️ Paladin",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Divine Sense",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Lay on Hands",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Divine Smite",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Aura of Protection",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Iriphawa",
            Age = @"39",
            Alignment = @"💛 Lawful neutral",
            Race = @"🧝🏻‍♂️ Half-Elf",
            Class = @"🏹 Ranger",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🏹 Favored Enemy",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🏹 Natural Explorer",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🏹 Primeval Awareness",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🏹 Land's Stride",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Quaf",
            Age = @"25",
            Alignment = @"💚 Neutral",
            Race = @"👩 Human",
            Class = @"🥊 Fighter",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Second Wind",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Action Surge",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Martial Archetype",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Extra Attack",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Rat Scratch",
            Age = @"15",
            Alignment = @"🤎 Neutral evil",
            Race = @"🐡 Locathah",
            Class = @"🍁 Druid",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🍁 Druidic",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🍁 Wild Shape",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🍁 Druid Circle",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🍁 Timeless Body",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Slicer",
            Age = @"57",
            Alignment = @"💜 Lawful evil",
            Race = @"🐡 Locathah",
            Class = @"💪 Barbarian",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"💪 Rage",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"💪 Unarmored Defense",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"💪 Reckless Attack",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"💪 Danger Sense",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Nereones Ahlorsath",
            Age = @"95",
            Alignment = @"💛 Lawful neutral",
            Race = @"👩 Human",
            Class = @"🥊 Fighter",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Second Wind",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Action Surge",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Martial Archetype",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Extra Attack",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Nalvarti Stonecutter",
            Age = @"118",
            Alignment = @"❤️ Neutral good",
            Race = @"🧝‍♀️ Elf",
            Class = @"❤️‍ Cleric",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"❤️‍ Divine Domain",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"❤️‍ Channel Divinity",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"❤️‍ Destroy Undead",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"❤️‍ Divine Intervention",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Errk",
            Age = @"22",
            Alignment = @"🤎 Neutral evil",
            Race = @"🧝🏻‍♂️ Half-Elf",
            Class = @"🎻 Bard",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Bardic Inspiration",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Countercharm",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Jack of All Trades",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Song of Rest",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Seven Thundercloud",
            Age = @"43",
            Alignment = @"💖 Lawful good",
            Race = @"🐡 Locathah",
            Class = @"⚔️ Paladin",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Divine Sense",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Lay on Hands",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Divine Smite",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Aura of Protection",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Navarra Chergoba",
            Age = @"16",
            Alignment = @"💜 Lawful evil",
            Race = @"🐯 Tabaxi",
            Class = @"❤️‍ Cleric",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"❤️‍ Divine Domain",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"❤️‍ Channel Divinity",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"❤️‍ Destroy Undead",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"❤️‍ Divine Intervention",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Sail Snap",
            Age = @"56",
            Alignment = @"💖 Lawful good",
            Race = @"🌳 Arboren",
            Class = @"💪 Barbarian",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"💪 Rage",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"💪 Unarmored Defense",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"💪 Reckless Attack",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"💪 Danger Sense",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Urreek",
            Age = @"17",
            Alignment = @"💜 Lawful evil",
            Race = @"🧝🏻‍♂️ Half-Elf",
            Class = @"🐉 Warlock",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🐉 Otherworldly Patron",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🐉 Pact Magic",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🐉 Eldritch Invocations",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🐉 Mystic Arcanum",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Morkral Firetamer",
            Age = @"24",
            Alignment = @"🤎 Neutral evil",
            Race = @"🐲 Dragonborn",
            Class = @"🙏🏻 Monk",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🙏🏻 Unarmored Defense",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🙏🏻 Martial Arts",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🙏🏻 Ki",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🙏🏻 Deflect Missiles",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Vithka",
            Age = @"53",
            Alignment = @"💜 Lawful evil",
            Race = @"🐡 Locathah",
            Class = @"⚔️ Paladin",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Divine Sense",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Lay on Hands",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Divine Smite",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"⚔️ Aura of Protection",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Sandrue Avhoste",
            Age = @"19",
            Alignment = @"💙 Chaotic Neutral",
            Race = @"🐲 Dragonborn",
            Class = @"🗡️ Rogue",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🗡️ Sneak Attack",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🗡️ Thieves' Cant",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🗡️ Cunning Action",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🗡️ Uncanny Dodge",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Hapah Moq",
            Age = @"34",
            Alignment = @"💜 Lawful evil",
            Race = @"🎅🏽 Dwarf",
            Class = @"🎻 Bard",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Bardic Inspiration",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Countercharm",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Jack of All Trades",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🎻 Song of Rest",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Kothar ",
            Age = @"55",
            Alignment = @"🤍 Unaligned",
            Race = @"🧝🏻‍♂️ Half-Elf",
            Class = @"🐉 Warlock",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🐉 Otherworldly Patron",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🐉 Pact Magic",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🐉 Eldritch Invocations",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🐉 Mystic Arcanum",
                    Level = @"4"
                }}

        });
        this.Add(new HGridDndDataItem()
        {
            Name = @"Senen",
            Age = @"40",
            Alignment = @"💜 Lawful evil",
            Race = @"🧒🏻 Hafling",
            Class = @"🥊 Fighter",
            Skills = new List<HGridDndDataItem_SkillsItem>()
            {
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Second Wind",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Action Surge",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Martial Archetype",
                    Level = @"4"
                },
                new HGridDndDataItem_SkillsItem()
                {
                    Skill = @"🥊 Extra Attack",
                    Level = @"4"
                }}

        });
    }
}

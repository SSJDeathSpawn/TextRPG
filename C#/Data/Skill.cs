using System;
using System.Collections.Generic;

namespace TextRPG.Data {
    public abstract class Skill {
        public SkillType skillType { get; set; }
        public string name { get; set; }

        public Skill(string name, SkillType skillType) {
            this.name = name;
            this.skillType = skillType;
        }
    }

    public enum SkillType {
        ATTACK,
        DEFENCE,
        STATUS,
        PASSIVE
    }
}
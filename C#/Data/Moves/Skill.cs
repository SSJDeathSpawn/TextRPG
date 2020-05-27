using System;
using System.Collections.Generic;

namespace TextRPG.Data.Moves {
    public class Skill {
        public SkillType skillType;
        public string name;

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
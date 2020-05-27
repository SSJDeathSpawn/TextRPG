using System;
using System.Collections.Generic;

namespace TextRPG.Data.Moves {
    public class AttackSkill: Skill {
        public int damage;
        //public Status status (Hype??)
        //public float chance;

        public AttackSkill(string name, int damage) : base(name, SkillType.ATTACK) {
            this.damage = damage;
        }

    }
}
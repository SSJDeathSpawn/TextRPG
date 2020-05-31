using System;
using System.Collections.Generic;
using TextRPG.Living.Ailments;
using TextRPG.Data;

namespace TextRPG.Data.Moves {
    public class AttackSkill: Skill {
        public int damage;
        public Tuple<StatusInstance, float> statusWithChance;
        public float chance;
        public float critChance;

        public AttackSkill(string name, int damage, Tuple<StatusInstance, float> statusWithChance, float chance, float critChance) : base(name, SkillType.ATTACK) {
            this.damage = damage;
            this.statusWithChance = statusWithChance;
            this.chance = chance;
            this.critChance = critChance;
        }

    }
}
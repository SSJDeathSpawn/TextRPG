using TextRPG.Living.Ailments;
using TextRPG.Data;

namespace TextRPG.Data.Moves {
    public class StatusSkill: Skill {
        StatusInstance toApply { get; set; }
        float chance { get; set; }
        public StatusSkill(string name, StatusInstance toApply, float chance): base(name, SkillType.STATUS) {
            this.toApply = toApply;
            this.chance = chance;
        }

    }
}
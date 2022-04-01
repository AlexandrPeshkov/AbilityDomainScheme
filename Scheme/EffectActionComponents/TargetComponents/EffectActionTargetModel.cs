namespace Scheme.Effects
{
    public class EffectActionTargetModel
    {
        public EffectTarget EffectTarget { get; set; }
        
        public EffectTargetPoint EffectTargetPoint { get; set; }
        
        public TargetEffectCreationType TargetEffectCreationType { get; set; }
        
        
        public AreaTargetSelectionModel AreaTargetSelectionModel { get; set; }
    }

    public enum EffectTarget
    {
        Self,

        Targets,
        
        Area,
    }

    public enum TargetType
    {
        Cell,
        
    }

    public enum EffectTargetPoint
    {
        Default,
        
        Weapon,
        
        Body,
        
        Head,
        
        InWorldPosByTarget
    }

    public enum TargetEffectCreationType
    {
        WorldPos,
        
        InnerTarget
    }
}
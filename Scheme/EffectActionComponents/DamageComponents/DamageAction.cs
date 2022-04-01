namespace Scheme.Effects.DamageComponents
{
    public class DamageAction : BaseEffectAction
    {
        public ElementType ElementType { get; set; }
        
        public DamageValueType DamageValueType { get; set; }
        
        public float Value { get; set; }
    }

    public enum DamageValueType
    {
        Absolute,
        
        Percent,

        TargetCurrentHpPercent,
        
        TargetMaxHpPercent,
    }
}
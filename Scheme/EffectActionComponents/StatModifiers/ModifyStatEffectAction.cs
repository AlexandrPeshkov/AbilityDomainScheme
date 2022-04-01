namespace Scheme.Effects.StatModifiers
{
    public class ModifyStatEffectAction : BaseEffectAction
    {
        public float Value { get; set; }
        
        public string StatId { get; set; }
        
        public ValueType ValueType { get; set; }
    }

    public enum ValueType
    {
        Absolute,

        Percent
    }
}
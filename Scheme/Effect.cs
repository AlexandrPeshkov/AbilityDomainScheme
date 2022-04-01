using System.Collections.Generic;
using Scheme.Effects;

namespace Scheme
{
    public class Effect
    {
        public string Id { get; set; }
        
        public float ImposeChance { get; set; }
        
        public float ActionChance { get; set; }
        
        public BaseEffectTrigger Trigger { get; set; }
        
        public List<BaseEffectAction> Actions { get; set; }
    }
}
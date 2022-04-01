using Scheme.Effects;

namespace Scheme.AttackProcessModels
{
    public class BaseCastProcess : BaseEffectAction
    {
        public int MaxTargetCount { get; set; }

        public AttackProcessTargetSelectionBehaviour TargetSelectionBehaviour{ get; set; }
    }

    public enum AttackProcessTargetSelectionBehaviour
    {
        CurrentTarget,
        
        ClosetTarget,
        
        FurthestTarget
    }
}
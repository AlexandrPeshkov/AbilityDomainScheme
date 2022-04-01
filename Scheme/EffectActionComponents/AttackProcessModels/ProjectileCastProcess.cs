using System.Collections.Generic;

namespace Scheme.AttackProcessModels
{
    public class ProjectileCastProcess : BaseCastProcess
    {
        public ProjectileModel ProjectileModel { get; set; }
        
        public float Speed { get; set; }
        
        public ProjectileTrajectory ProjectileTrajectory { get; set; }
        
        public List<Effect> ProjectileEffects { get; set; }
    }
    
    public enum ProjectileTrajectory
    {
        Linear,
        
        Parabolic,
        
        Chaos,
        
        BindToTarget
    }
    
}
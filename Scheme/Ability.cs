using System;
using System.Collections.Generic;

namespace Scheme
{
    public class Ability
    {
        public string Id { get; set; }  
        
        public string Description { get; set; }  
        
        public string Name { get; set; }  
        
        public CastResource Cost { get; set; }  
        
        public float Cooldown { get; set; }
        
        public List<Effect> Effects { get; set; }
    }
}
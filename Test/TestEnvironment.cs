using System.Collections.Generic;
using Scheme;
using Scheme.AttackProcessModels;
using Scheme.Effects;
using Scheme.Effects.DamageComponents;
using Scheme.Effects.Visual;

namespace Test
{
    public class TestEnvironment
    {
        public Ability BaseFireBall()
        {
            return new Ability
            {
                Id = "ability.fireaball",
                Name = "Базовая атака",
                Description = "Стреляет файрболлами, раз в 1,5 секунды.",
                Cooldown = 1.5f,
                Cost = new ManaCastResource
                {
                    Value = 100
                },

                Effects = new List<Effect>()
                {
                    new Effect()
                    {
                        Id = "effect.projectile.fireball",
                        Trigger = new InstantTrigger(),
                        ActionChance = 1f,
                        ImposeChance = 1f,
                        Actions = new List<BaseEffectAction>()
                        {
                            new ProjectileCastProcess()
                            {
                                TargetSelectionBehaviour = AttackProcessTargetSelectionBehaviour.CurrentTarget,
                                TargetModel = new EffectActionTargetModel()
                                {
                                    EffectTarget = EffectTarget.Targets,
                                    EffectTargetPoint = EffectTargetPoint.Body
                                },

                                MaxTargetCount = 1,
                                Speed = 10f,
                                ProjectileTrajectory = ProjectileTrajectory.Linear,
                                ProjectileModel = new ProjectileModel()
                                {
                                    Id = "projectile.fireball"
                                },
                                ProjectileEffects = new List<Effect>()
                                {
                                    new Effect()
                                    {
                                        Id = "effect.fireDamage",
                                        ActionChance = 1,
                                        ImposeChance = 1f,
                                        Trigger = new ProjectileHitTrigger(),
                                        Actions = new List<BaseEffectAction>()
                                        {
                                            new DamageAction()
                                            {
                                                DamageValueType = DamageValueType.Percent,
                                                ElementType = ElementType.Fire,
                                                Value = 1f,
                                                TargetModel = new EffectActionTargetModel()
                                                {
                                                    EffectTarget = EffectTarget.Targets,
                                                    EffectTargetPoint = EffectTargetPoint.Default,
                                                    AreaTargetSelectionModel = new PointTargetModel()
                                                }
                                            },

                                            new DamageAction()
                                            {
                                                DamageValueType = DamageValueType.Percent,
                                                ElementType = ElementType.Base,
                                                Value = 1f,
                                                TargetModel = new EffectActionTargetModel()
                                                {
                                                    EffectTarget = EffectTarget.Targets,
                                                    EffectTargetPoint = EffectTargetPoint.Default,
                                                    AreaTargetSelectionModel = new PointTargetModel()
                                                }
                                            },

                                            new VfxEffectAction()
                                            {
                                                VfxId = "vfx.firePuf",
                                                TargetModel = new EffectActionTargetModel()
                                                {
                                                    EffectTarget = EffectTarget.Targets,
                                                    EffectTargetPoint = EffectTargetPoint.Default,
                                                    TargetEffectCreationType = TargetEffectCreationType.WorldPos,
                                                    AreaTargetSelectionModel = new PointTargetModel()
                                                }
                                            },

                                            new CastEffectAction()
                                            {
                                                Effect = new Effect()
                                                {
                                                    Id = "effect.fireAoe",
                                                    ImposeChance = 1f,
                                                    ActionChance = 1f,
                                                    Trigger = new InstantTrigger(),
                                                    Actions = new List<BaseEffectAction>()
                                                    {
                                                        new VfxEffectAction
                                                        {
                                                            VfxId = "vfx.fireTile",
                                                            TargetModel = new EffectActionTargetModel()
                                                            {
                                                                EffectTarget = Effe ctTarget.Targets,
                                                                EffectTargetPoint = EffectTargetPoint.Default,
                                                                TargetEffectCreationType = TargetEffectCreationType.InnerTarget,
                                                                AreaTargetSelectionModel = new AoeTargetModel()
                                                                {
                                                                    Range = 10f,
                                                                    Type = targetType.Tile || targetType.enemies
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
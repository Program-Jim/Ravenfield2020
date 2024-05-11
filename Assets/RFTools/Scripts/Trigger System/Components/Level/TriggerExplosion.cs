using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
    [AddComponentMenu("Trigger/Level/Trigger Explosion")]
    [TriggerDoc("When Triggered, Creates and explosion credited to the CreditedActor. Sends OnHitAnything if anything was hit (IE would produce a hitmarker if player is the credited actor), otherwise sends OnHitNothing.")]
    public class TriggerExplosion : TriggerReceiver
    {
        public Transform center;
        public ExplodingProjectile.ExplosionConfiguration explosion;
        public Vehicle.ArmorRating damageRating;
        public GameObject objectToActivate;

        public ActorReference creditedActor;
        public bool reduceFriendlyFireDamage = false;

        [Header("Sends")]
        public TriggerSend onHitAnything;
        public TriggerSend onHitNothing;

		public void Reset() {
            this.center = this.transform;

            this.explosion = new ExplodingProjectile.ExplosionConfiguration() {
                balanceFalloff = new AnimationCurve(new Keyframe(0f, 1f), new Keyframe(1f, 0f)),
                damageFalloff = new AnimationCurve(new Keyframe(0f, 1f), new Keyframe(1f, 0f)),
            };
		}
	}
}

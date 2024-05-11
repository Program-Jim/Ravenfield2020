using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Actor/Trigger Fire Weapon")]
	[TriggerDoc("When Triggered, Fires a single shot on a weapon. Sends OnFired or OnCouldntFire depending on if a round was fired or not.")]
    public class TriggerFireWeapon : TriggerReceiver
    {
        public WeaponReference weapon;
		public bool ignoreCanFireCheck;

		public TriggerSend onFired, onCouldntFire;
	}
}

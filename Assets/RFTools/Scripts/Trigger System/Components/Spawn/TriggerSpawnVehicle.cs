using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Spawn/Trigger Spawn Vehicle")]
	[TriggerDoc("When triggered, Spawns a vehicle on the specified VehicleSpawner")]
	public class TriggerSpawnVehicle : TriggerReceiver
	{
		[Header("Parameters")]
		public Team team;
		public VehicleSpawner vehicleSpawner;
		public VehicleInfo vehicleInfo = VehicleInfo.Default;

		[Header("Sends")]
		public TriggerSend onSpawnCompleteTrigger;

		private void Reset() {
			this.vehicleSpawner = GetComponent<VehicleSpawner>();
		}

		[System.Serializable]
		public struct VehicleInfo
		{
			static public VehicleInfo Default {
				get {
					return new VehicleInfo() {
						isInvulnerable = false,
						isLocked = false,
						canBeTakenOverByPlayerSquad = true,
					};
				}
			}

			public bool isInvulnerable;
			public bool isLocked;
			public bool canBeTakenOverByPlayerSquad;
		}
	}
}

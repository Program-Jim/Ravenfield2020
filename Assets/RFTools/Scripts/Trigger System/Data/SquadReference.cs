using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Ravenfield.Trigger
{
	[System.Serializable]
	public struct SquadReference
	{
		public static Squad lastSpawnedSquad;

		public enum Type
		{
			Spawner,
			PlayerSquad,
			FindClosest,
			LastSpawned,
			FromSignal,
		}

		public Type type;
		[ConditionalField("type", Type.Spawner)] public TriggerSpawnSquad spawner;

		[ConditionalField("type", Type.FindClosest)] public Transform closestToPoint;
		[ConditionalField("type", Type.FindClosest)] public SquadFilter filter;
		[ConditionalField("type", Type.FindClosest)] public float maxDistance;
	}
}
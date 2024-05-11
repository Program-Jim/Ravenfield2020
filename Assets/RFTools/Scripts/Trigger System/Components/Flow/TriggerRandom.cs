using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Flow/Trigger Random")]
	[TriggerDoc("When triggered, sends OnPass based on Chance value, otherwise sends onFail")]
	public class TriggerRandom : TriggerReceiver
	{
		[Range(0f, 1f)] public float chance = 0.5f;
		public TriggerSend onPass, onFail;
	}
}
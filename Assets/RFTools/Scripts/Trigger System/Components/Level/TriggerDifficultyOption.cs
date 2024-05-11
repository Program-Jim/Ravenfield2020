using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Level/Trigger Difficulty Option")]
	[TriggerDoc("When triggered, sends a signal based on the selected game difficulty.")]
	public class TriggerDifficultyOption : TriggerReceiver
	{
		public TriggerSend easySend;
		public TriggerSend normalSend;
		public TriggerSend hardSend;
	}
}
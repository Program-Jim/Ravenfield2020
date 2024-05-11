using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Flow/Trigger Sequence")]
	[TriggerDoc("When triggered, sends a signal to a single destination in SequencedSend one by one, in order.")]
	public class TriggerSequence : TriggerReceiver
	{
		[AutoPopulateChildReceivers] public TriggerSend sequencedSend;
	}
}
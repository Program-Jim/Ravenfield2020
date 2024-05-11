using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[TriggerDoc("When Triggered, all members in FromSquad joins ToSquad.")]
	[AddComponentMenu("Trigger/AI/Trigger Join Squad")]
    public class TriggerJoinSquad : TriggerReceiver
    {
		public SquadReference fromSquad;
		public SquadReference toSquad;

		public TriggerSend onSquadsJoined;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Flow/Trigger Load Checkpoint")]
	[TriggerDoc("Sends OnCheckpointLoaded when the level starts with the specified checkpoint value.")]
	public class TriggerLoadCheckpoint : TriggerBaseComponent
	{
		public ScriptedGameMode.Checkpoint checkpoint;
		[InspectorName("On Checkpoint Loaded"), AutoPopulateChildReceivers] public TriggerSend onCheckpointLoadedTrigger;
	}
}
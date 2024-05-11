using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
    [AddComponentMenu("Trigger/AI/Trigger Detection Group")]
    [TriggerDoc("Alerts a group of squads when one of the squads detect an enemy. Sends OnGroupAlerted when this group is is alerted by a member squad.")]
    public class TriggerDetectionGroup : TriggerBaseComponent
    {
        [System.NonSerialized] public bool groupAlerted = false;
        public TriggerSend onGroupAlerted;

        [System.NonSerialized] public List<Squad> squadsInGroup = new List<Squad>();

        public enum AlertType
		{
            OnSingleSquadAlerted,
		}

        public AlertType alertGroupType;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
    [System.Serializable]
    public struct TriggerSend
    {
        public List<TriggerReceiver> destinations;
    }
}
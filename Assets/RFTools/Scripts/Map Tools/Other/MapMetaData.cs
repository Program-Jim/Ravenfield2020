using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MapMetaData
{
	public static MapMetaData Default {
		get {
			return new MapMetaData() {
				hasBuiltInGameMode = false,
				suggestedBots = 60,
			};
		}
	}

	public void WriteToFile(string path) {

	}

	public bool hasBuiltInGameMode;
	public bool usesTriggerSystem;
	public int suggestedBots;
	public string displayName;
}

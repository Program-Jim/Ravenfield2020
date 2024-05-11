using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

public class MetaDataWindow : EditorWindow
{
	[MenuItem("Ravenfield Tools/Map/Metadata Editor")]
	public static void PublishToWorkshop() {
		MetaDataWindow window = EditorWindow.GetWindow<MetaDataWindow>();
		window.titleContent.text = "Scene Metadata";
		window.Show();
	}

	private void OnEnable() {
		this.hasLoadedMetaData = false;
	}

	bool hasLoadedMetaData;
	MapMetaData metadata;

	void LoadMetadata() {
		var currentScene = EditorSceneManager.GetSceneAt(0);

		if (!MetaDataUtils.MetaDataExistsFor(currentScene.path)) {
			MetaDataUtils.WriteMetaData(currentScene.path, MapMetaData.Default);
		}

		this.hasLoadedMetaData = MetaDataUtils.ReadMetaData(currentScene.path, out this.metadata);
	}

	void SaveMetadata() {
		var currentScene = EditorSceneManager.GetSceneAt(0);
		MetaDataUtils.WriteMetaData(currentScene.path, this.metadata);
		Debug.Log($"Saved {currentScene.name} metadata!");
	}

	void OnGUI() {
		if(GUILayout.Button("Create/Load Metadata")) {
			LoadMetadata();
			GUI.FocusControl(null);
			Repaint();
		}

		if (!this.hasLoadedMetaData) return;

		EditorGUILayout.LabelField("Metadata:");

		this.metadata.displayName = EditorGUILayout.TextField("Display Name", this.metadata.displayName);
		this.metadata.suggestedBots = EditorGUILayout.IntField("Suggested Bots", this.metadata.suggestedBots);

		if(GUILayout.Button("Save Changes")) {
			SaveMetadata();
		}
	}
}

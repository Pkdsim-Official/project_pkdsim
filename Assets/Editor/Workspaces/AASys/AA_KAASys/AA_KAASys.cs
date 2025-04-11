using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
using UnityEngine;

namespace project_pkdsim.Assets.Editor.Workspaces.AASys.AddressableKeyAutoAssigner
{
	public static class AddressableKeyAutoAssigner
	{
		[MenuItem("Pkdsim/Jobs/Tools/Addressables/Auto Assign Addressable Keys")]
		public static void AutoAssignKeys()
		{
			var settings = AddressableAssetSettingsDefaultObject.Settings;

			string[] guids = AssetDatabase.FindAssets("", new[] { "Assets/UPokemon" });

			foreach (var guid in guids)
			{
				string path = AssetDatabase.GUIDToAssetPath(guid);
				var entry = settings.CreateOrMoveEntry(guid, settings.DefaultGroup);
				string key = path.Replace("Assets/", "").Replace(".prefab", "").Replace(".anim", "");
				entry.address = key; // Mimics full folder path structure
			}

			AssetDatabase.SaveAssets();
			Debug.Log("Addressable keys set based on folder structure.");
		}
		public void AASys_AutoAssignKeysInitializer () {
			
		}
	}
}
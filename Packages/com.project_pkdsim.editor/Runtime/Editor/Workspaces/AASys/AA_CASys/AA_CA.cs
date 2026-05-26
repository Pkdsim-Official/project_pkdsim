using UnityEditor;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

namespace project_pkdsim.Editor.Workspaces.AASys.ClearAddressablesCacheSys
{
	public class AA_CASys : MonoBehaviour
	{
		[MenuItem("Pkdsim/Jobs/Tools/Addressables/Clear Cache")]
		private static void ClearCache()
		{
			AddressableAssetSettings.CleanPlayerContent();
			Debug.Log("Addressables cache cleared.");
		}
		public void AASys_ClearCacheInitializer()
		{
			ClearCache();
		}
	}
}
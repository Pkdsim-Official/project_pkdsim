using project_pkdsim.Assets.Editor.Workspaces.AASys.CloudSaveInitializerSys;
using project_pkdsim.Assets.Editor.Workspaces.AASys.ClearAddressablesCacheSys;
using project_pkdsim.Assets.Editor.Workspaces.AASys.AddressableKeyAutoAssigner;
using UnityEngine;

namespace project_pkdsim.Assets.Editor.Workspaces.AASys.I
{
	public class Editor_AASysI : MonoBehaviour 
	{
		private AA_CASys AA_CASys;
		private AA_CLSASys AA_CLSASys;

		private AA_KAASys AA_KAASys;
		private void Get_AA_CLSASys()
		{
			AA_CLSASys.AASys_CloudSaveInitializer();
		}
		private void Get_AA_CASys()
		{
			AA_CASys.AASys_ClearCacheInitializer();
		}
		private void Get_AA_KAASys()
		{
			AA_KAASys.AASys_AutoAssignKeysInitializer();
		}
		public void AASys_Init() 
		{
			Get_AA_CASys();
			Get_AA_CLSASys();
			Get_AA_KAASys();
		}
	}
}
using project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TSys_OTBS.Npc;
using project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TSys_OTBS.Parents;
using UnityEngine;

namespace project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TABSys_OTBS
{
        public class TABSys_OnTabSelected : MonoBehaviour
        {
			private ParentsOTBS parentsOTBS;
			private NpcOTBS npcOTBS;

			protected NpcOTBS GetNpc() 
			{
					return npcOTBS;        
			}
			protected ParentsOTBS GetParents()
			{
					return parentsOTBS;
			}

			public void SetParentsOTBS(ParentsOTBS parentsOTBS)
			{
					this.parentsOTBS = parentsOTBS;
			}
			public void SetNpcOTBS(NpcOTBS npcOTBS)
			{
					this.npcOTBS = npcOTBS;
			}

			public void DisplayCurrentTab()
			{
				if (parentsOTBS != null && npcOTBS != null)
				{
					if (parentsOTBS != null) 
					{
						parentsOTBS.DisplayCurrentTab();
					}

					else if (npcOTBS != null) 
					{
						npcOTBS.DisplayCurrentTab();
					}

					else
					{
						Debug.LogWarning("TABSys_OTBS is not initialized");
					}
				}
			}
        }
}

using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark
{
	public class LFS_ZoroarkParentsFailSafe : MonoBehaviour 
	{
		private ZoroarkParentDad_FailSafe ZoroarkParentDad_FailSafe;
		private ZoroarkParentMom_FailSafe ZoroarkParentMom_FailSafe;
		public void Load_ZoroarkParentsFailSafe()
		{
			Load_ZoroarkParentDad_FailSafe();
			Load_ZoroarkParentMom_FailSafe();	
		}
		private void Load_ZoroarkParentDad_FailSafe()
		{
			ZoroarkParentDad_FailSafe.LoadFailSafeZoroarkParentDad_AnimatorController();
		}
		private void Load_ZoroarkParentMom_FailSafe()
		{
			ZoroarkParentMom_FailSafe.LoadFailSafeZoroarkParentMom_AnimatorController();
		}
	}
}
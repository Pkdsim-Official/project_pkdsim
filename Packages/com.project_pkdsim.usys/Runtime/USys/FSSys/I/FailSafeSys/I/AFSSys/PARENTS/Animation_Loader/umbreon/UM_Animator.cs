using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon
{
	public class LFS_UmbreonParentsFailSafe : MonoBehaviour 
	{
		private UmbreonParentDad_FailSafe UmbreonParentDad_FailSafe;
		private UmbreonParentMom_FailSafe UmbreonParentMom_FailSafe;
		public void Load_UmbreonParentsFailSafe()
		{
			Load_UmbreonParentDad_FailSafe();
			Load_UmbreonParentMom_FailSafe();	
		}
		private void Load_UmbreonParentDad_FailSafe()
		{
			UmbreonParentDad_FailSafe.LoadFailSafeUmbreonParentDad_AnimatorController();
		}
		private void Load_UmbreonParentMom_FailSafe()
		{
			UmbreonParentMom_FailSafe.LoadFailSafeUmbreonParentMom_AnimatorController();
		}	
	}
}
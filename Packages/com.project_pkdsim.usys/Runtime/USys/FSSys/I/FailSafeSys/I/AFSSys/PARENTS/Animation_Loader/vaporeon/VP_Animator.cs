using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon
{
	public class LFS_VaporeonParentsFailSafe : MonoBehaviour 
	{
		private VaporeonParentDad_FailSafe VaporeonParentDad_FailSafe;
		private VaporeonParentMom_FailSafe VaporeonParentMom_FailSafe;
		public void Load_VaporeonParentsFailSafe()
		{
			Load_VaporeonParentDad_FailSafe();
			Load_VaporeonParentMom_FailSafe();	
		}
		private void Load_VaporeonParentDad_FailSafe()
		{
			VaporeonParentDad_FailSafe.LoadFailSafeVaporeonParentDad_AnimatorController();
		}
		private void Load_VaporeonParentMom_FailSafe()
		{
			VaporeonParentMom_FailSafe.LoadFailSafeVaporeonParentMom_AnimatorController();
		}
	}
}
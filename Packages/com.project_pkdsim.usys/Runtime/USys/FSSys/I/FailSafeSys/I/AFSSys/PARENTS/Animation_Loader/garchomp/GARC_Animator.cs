using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp
{
	public class LFS_GarchompParentsFailSafe : MonoBehaviour 
	{
		private GarchompParentDad_FailSafe GarchompParentDad_FailSafe;
		private GarchompParentMom_FailSafe GarchompParentMom_FailSafe;
		public void Load_GarchompParentsFailSafe()
		{
			Load_GarchompParentDad_FailSafe();
			Load_GarchompParentMom_FailSafe();	
		}
		private void Load_GarchompParentDad_FailSafe()
		{
			GarchompParentDad_FailSafe.LoadFailSafeGarchompParentDad_AnimatorController();
		}
		private void Load_GarchompParentMom_FailSafe()
		{
			GarchompParentMom_FailSafe.LoadFailSafeGarchompParentMom_AnimatorController();
		}

	}
}
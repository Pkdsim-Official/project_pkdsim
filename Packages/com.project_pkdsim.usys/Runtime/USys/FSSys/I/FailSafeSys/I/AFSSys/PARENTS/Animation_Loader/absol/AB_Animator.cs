using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol
{
	public class LFS_AbsolParentsFailSafe : MonoBehaviour 
	{
		private AbsolParentDad_FailSafe AbsolParentDad_FailSafe;
		private AbsolParentMom_FailSafe AbsolParentMom_FailSafe;
		public void Load_AbsolParentsFailSafe()
		{
			Load_AbsolParentDad_FailSafe();
			Load_AbsolParentMom_FailSafe();	
		}
		private void Load_AbsolParentDad_FailSafe()
		{
			AbsolParentDad_FailSafe.LoadFailSafeAbsolParentDad_AnimatorController();
		}
		private void Load_AbsolParentMom_FailSafe()
		{
			AbsolParentMom_FailSafe.LoadFailSafeAbsolParentMom_AnimatorController();
		}
	}
}
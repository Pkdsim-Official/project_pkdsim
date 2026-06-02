using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern
{
	public class LFS_NoivernParentsFailSafe : MonoBehaviour 
	{
		private NoivernParentDad_FailSafe NoivernParentDad_FailSafe;
		private NoivernParentMom_FailSafe NoivernParentMom_FailSafe;
		public void Load_NoivernParentsFailSafe()
		{
			Load_NoivernParentDad_FailSafe();
			Load_NoivernParentMom_FailSafe();	
		}
		private void Load_NoivernParentDad_FailSafe()
		{
			NoivernParentDad_FailSafe.LoadFailSafeNoivernParentDad_AnimatorController();
		}
		private void Load_NoivernParentMom_FailSafe()
		{
			NoivernParentMom_FailSafe.LoadFailSafeNoivernParentMom_AnimatorController();
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace
{
	public class LFS_CinderaceParentsFailSafe : MonoBehaviour 
	{
		private CinderaceParentDad_FailSafe CinderaceParentDad_FailSafe;
		private CinderaceParentMom_FailSafe CinderaceParentMom_FailSafe;
		public void Load_CinderaceParentsFailSafe()
		{
			Load_CinderaceParentDad_FailSafe();
			Load_CinderaceParentMom_FailSafe();
		}
		private void Load_CinderaceParentDad_FailSafe()
		{
			CinderaceParentDad_FailSafe.LoadFailSafeCinderaceParentDad_AnimatorController();
		}
		private void Load_CinderaceParentMom_FailSafe()
		{
			CinderaceParentMom_FailSafe.LoadFailSafeCinderaceParentMom_AnimatorController();
		}
	}
}
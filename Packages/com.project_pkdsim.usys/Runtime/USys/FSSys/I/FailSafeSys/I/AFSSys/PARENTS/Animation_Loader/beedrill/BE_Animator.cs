using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill
{
	public class LFS_BeedrillParentsFailSafe : MonoBehaviour 
	{
		private BeedrillParentDad_FailSafe BeedrillParentDad_FailSafe;
		private BeedrillParentMom_FailSafe BeedrillParentMom_FailSafe;
		public void Load_BeedrillParentsFailSafe()
		{
			Load_BeedrillParentDad_FailSafe();
			Load_BeedrillParentMom_FailSafe();	
		}
		private void Load_BeedrillParentDad_FailSafe()
		{
			BeedrillParentDad_FailSafe.LoadFailSafeBeedrillParentDad_AnimatorController();
		}
		private void Load_BeedrillParentMom_FailSafe()
		{
			BeedrillParentMom_FailSafe.LoadFailSafeBeedrillParentMom_AnimatorController();
		}
	}
}
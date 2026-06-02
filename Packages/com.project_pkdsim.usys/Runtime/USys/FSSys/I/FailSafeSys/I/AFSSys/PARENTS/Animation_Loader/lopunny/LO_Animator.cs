using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny
{
	public class LFS_LopunnyParentsFailSafe : MonoBehaviour 
	{
		private LopunnyParentDad_FailSafe LopunnyParentDad_FailSafe;
		private LopunnyParentMom_FailSafe LopunnyParentMom_FailSafe;
		public void Load_LopunnyParentsFailSafe()
		{
			Load_LopunnyParentDad_FailSafe();
			Load_LopunnyParentMom_FailSafe();	
		}
		private void Load_LopunnyParentDad_FailSafe()
		{
			LopunnyParentDad_FailSafe.LoadFailSafeLopunnyParentDad_AnimatorController();
		}
		private void Load_LopunnyParentMom_FailSafe()
		{
			LopunnyParentMom_FailSafe.LoadFailSafeLopunnyParentMom_AnimatorController();
		}	
	}
}
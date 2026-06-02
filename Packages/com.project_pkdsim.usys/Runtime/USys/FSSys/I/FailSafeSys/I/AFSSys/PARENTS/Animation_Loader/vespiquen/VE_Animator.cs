using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen
{
	public class LFS_VespiquenParentsFailSafe : MonoBehaviour 
	{
		private VespiquenParentDad_FailSafe VespiquenParentDad_FailSafe;
		private VespiquenParentMom_FailSafe VespiquenParentMom_FailSafe;
		public void Load_VespiquenParentsFailSafe()
		{
			Load_VespiquenParentDad_FailSafe();
			Load_VespiquenParentMom_FailSafe();	
		}
		private void Load_VespiquenParentDad_FailSafe()
		{
			VespiquenParentDad_FailSafe.LoadFailSafeVespiquenParentDad_AnimatorController();
		}
		private void Load_VespiquenParentMom_FailSafe()
		{
			VespiquenParentMom_FailSafe.LoadFailSafeVespiquenParentMom_AnimatorController();
		}
	}
}
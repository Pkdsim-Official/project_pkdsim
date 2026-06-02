using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala
{
	public class LFS_LunalaParentsFailSafe : MonoBehaviour 
	{
		private LunalaParentDad_FailSafe LunalaParentDad_FailSafe;
		private LunalaParentMom_FailSafe LunalaParentMom_FailSafe;
		public void Load_LunalaParentsFailSafe()
		{
			Load_LunalaParentDad_FailSafe();
			Load_LunalaParentMom_FailSafe();	
		}
		private void Load_LunalaParentDad_FailSafe()
		{
			LunalaParentDad_FailSafe.LoadFailSafeLunalaParentDad_AnimatorController();
		}
		private void Load_LunalaParentMom_FailSafe()
		{
			LunalaParentMom_FailSafe.LoadFailSafeLunalaParentMom_AnimatorController();
		}		
	}
}
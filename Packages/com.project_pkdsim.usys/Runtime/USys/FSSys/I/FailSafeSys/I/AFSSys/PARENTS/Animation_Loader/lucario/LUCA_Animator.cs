using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario
{
	public class LFS_LucarioParentsFailSafe : MonoBehaviour 
	{
		private LucarioParentDad_FailSafe LucarioParentDad_FailSafe;
		private LucarioParentMom_FailSafe LucarioParentMom_FailSafe;
		public void Load_LucarioParentsFailSafe()
		{
			Load_LucarioParentDad_FailSafe();
			Load_LucarioParentMom_FailSafe();	
		}
		private void Load_LucarioParentDad_FailSafe()
		{
			LucarioParentDad_FailSafe.LoadFailSafeLucarioParentDad_AnimatorController();
		}
		private void Load_LucarioParentMom_FailSafe()
		{
			LucarioParentMom_FailSafe.LoadFailSafeLucarioParentMom_AnimatorController();
		}	
	}
}
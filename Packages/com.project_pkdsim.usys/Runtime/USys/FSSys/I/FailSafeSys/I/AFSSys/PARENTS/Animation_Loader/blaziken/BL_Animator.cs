using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken
{
	public class LFS_BlazikenParentsFailSafe : MonoBehaviour 
	{
		private BlazikenParentDad_FailSafe BlazikenParentDad_FailSafe;
		private BlazikenParentMom_FailSafe BlazikenParentMom_FailSafe;
		public void Load_BlazikenParentsFailSafe()
		{
			Load_BlazikenParentDad_FailSafe();
			Load_BlazikenParentMom_FailSafe();	
		}
		private void Load_BlazikenParentDad_FailSafe()
		{
			BlazikenParentDad_FailSafe.LoadFailSafeBlazikenParentDad_AnimatorController();
		}
		private void Load_BlazikenParentMom_FailSafe()
		{
			BlazikenParentMom_FailSafe.LoadFailSafeBlazikenParentMom_AnimatorController();
		}
	}
}
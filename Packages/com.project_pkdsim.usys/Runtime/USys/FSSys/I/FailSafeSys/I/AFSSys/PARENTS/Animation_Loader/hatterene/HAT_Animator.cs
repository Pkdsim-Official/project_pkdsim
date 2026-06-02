using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene
{
	public class LFS_HattereneParentsFailSafe : MonoBehaviour 
	{
		private HattereneParentDad_FailSafe HattereneParentDad_FailSafe;
		private HattereneParentMom_FailSafe HattereneParentMom_FailSafe;
		public void Load_HattereneParentsFailSafe()
		{
			Load_HattereneParentDad_FailSafe();
			Load_HattereneParentMom_FailSafe();	
		}
		private void Load_HattereneParentDad_FailSafe()
		{
			HattereneParentDad_FailSafe.LoadFailSafeHattereneParentDad_AnimatorController();
		}
		private void Load_HattereneParentMom_FailSafe()
		{
			HattereneParentMom_FailSafe.LoadFailSafeHattereneParentMom_AnimatorController();
		}	
	}
}
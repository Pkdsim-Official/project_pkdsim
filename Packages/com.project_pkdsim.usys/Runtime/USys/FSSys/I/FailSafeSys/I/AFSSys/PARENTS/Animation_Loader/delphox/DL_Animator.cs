using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox
{
	public class LFS_DelphoxParentsFailSafe : MonoBehaviour 
	{
		private DelphoxParentDad_FailSafe DelphoxParentDad_FailSafe;
		private DelphoxParentMom_FailSafe DelphoxParentMom_FailSafe;
		public void Load_DelphoxParentsFailSafe()
		{
			Load_DelphoxParentDad_FailSafe();
			Load_DelphoxParentMom_FailSafe();	
		}
		private void Load_DelphoxParentDad_FailSafe()
		{
			DelphoxParentDad_FailSafe.LoadFailSafeDelphoxParentDad_AnimatorController();
		}
		private void Load_DelphoxParentMom_FailSafe()
		{
			DelphoxParentMom_FailSafe.LoadFailSafeDelphoxParentMom_AnimatorController();
		}
	}
}
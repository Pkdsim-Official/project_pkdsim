using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass
{
	public class LFS_FrostlassParentsFailSafe : MonoBehaviour 
	{
		private FrostlassParentDad_FailSafe FrostlassParentDad_FailSafe;
		private FrostlassParentMom_FailSafe FrostlassParentMom_FailSafe;
		public void Load_FrostlassParentsFailSafe()
		{
			Load_FrostlassParentDad_FailSafe();
			Load_FrostlassParentMom_FailSafe();	
		}
		private void Load_FrostlassParentDad_FailSafe()
		{
			FrostlassParentDad_FailSafe.LoadFailSafeFrostlassParentDad_AnimatorController();
		}
		private void Load_FrostlassParentMom_FailSafe()
		{
			FrostlassParentMom_FailSafe.LoadFailSafeFrostlassParentMom_AnimatorController();
		}
	}
}
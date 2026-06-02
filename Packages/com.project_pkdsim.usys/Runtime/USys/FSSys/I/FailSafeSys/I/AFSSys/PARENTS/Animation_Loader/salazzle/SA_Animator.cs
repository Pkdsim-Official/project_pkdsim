using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle
{
	public class LFS_SalazzleParentsFailSafe : MonoBehaviour 
	{
		private SalazzleParentDad_FailSafe SalazzleParentDad_FailSafe;
		private SalazzleParentMom_FailSafe SalazzleParentMom_FailSafe;
		public void Load_SalazzleParentsFailSafe()
		{
			Load_SalazzleParentDad_FailSafe();
			Load_SalazzleParentMom_FailSafe();	
		}
		private void Load_SalazzleParentDad_FailSafe()
		{
			SalazzleParentDad_FailSafe.LoadFailSafeSalazzleParentDad_AnimatorController();
		}
		private void Load_SalazzleParentMom_FailSafe()
		{
			SalazzleParentMom_FailSafe.LoadFailSafeSalazzleParentMom_AnimatorController();
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada
{
	public class LFS_MeowscaradaParentsFailSafe : MonoBehaviour 
	{
		private MeowscaradaParentDad_FailSafe MeowscaradaParentDad_FailSafe;
		private MeowscaradaParentMom_FailSafe MeowscaradaParentMom_FailSafe;
		public void Load_MeowscaradaParentsFailSafe()
		{
			Load_MeowscaradaParentDad_FailSafe();
			Load_MeowscaradaParentMom_FailSafe();	
		}
		private void Load_MeowscaradaParentDad_FailSafe()
		{
			MeowscaradaParentDad_FailSafe.LoadFailSafeMeowscaradaParentDad_AnimatorController();
		}
		private void Load_MeowscaradaParentMom_FailSafe()
		{
			MeowscaradaParentMom_FailSafe.LoadFailSafeMeowscaradaParentMom_AnimatorController();
		}
	}
}
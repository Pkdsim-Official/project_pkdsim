using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina
{
	public class LFS_PrimarinaParentsFailSafe : MonoBehaviour 
	{
		private PrimarinaParentDad_FailSafe PrimarinaParentDad_FailSafe;
		private PrimarinaParentMom_FailSafe PrimarinaParentMom_FailSafe;
		public void Load_PrimarinaParentsFailSafe()
		{
			Load_PrimarinaParentDad_FailSafe();
			Load_PrimarinaParentMom_FailSafe();	
		}
		private void Load_PrimarinaParentDad_FailSafe()
		{
			PrimarinaParentDad_FailSafe.LoadFailSafePrimarinaParentDad_AnimatorController();
		}
		private void Load_PrimarinaParentMom_FailSafe()
		{
			PrimarinaParentMom_FailSafe.LoadFailSafePrimarinaParentMom_AnimatorController();
		}	
	}
}
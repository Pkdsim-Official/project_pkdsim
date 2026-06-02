using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir
{
	public class LFS_GardevoirParentsFailSafe : MonoBehaviour 
	{
		private GardevoirParentDad_FailSafe GardevoirParentDad_FailSafe;
		private GardevoirParentMom_FailSafe GardevoirParentMom_FailSafe;
		public void Load_GardevoirParentsFailSafe()
		{
			Load_GardevoirParentDad_FailSafe();
			Load_GardevoirParentMom_FailSafe();	
		}
		private void Load_GardevoirParentDad_FailSafe()
		{
			GardevoirParentDad_FailSafe.LoadFailSafeGardevoirParentDad_AnimatorController();
		}
		private void Load_GardevoirParentMom_FailSafe()
		{
			GardevoirParentMom_FailSafe.LoadFailSafeGardevoirParentMom_AnimatorController();
		}	
	}
}
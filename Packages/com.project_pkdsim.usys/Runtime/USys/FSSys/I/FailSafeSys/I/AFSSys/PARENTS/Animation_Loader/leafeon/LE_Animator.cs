using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon
{
	public class LFS_LeafeonParentsFailSafe : MonoBehaviour 
	{
		private LeafeonParentDad_FailSafe LeafeonParentDad_FailSafe;
		private LeafeonParentMom_FailSafe LeafeonParentMom_FailSafe;
		public void Load_LeafeonParentsFailSafe()
		{
			Load_LeafeonParentDad_FailSafe();
			Load_LeafeonParentMom_FailSafe();	
		}
		private void Load_LeafeonParentDad_FailSafe()
		{
			LeafeonParentDad_FailSafe.LoadFailSafeLeafeonParentDad_AnimatorController();
		}
		private void Load_LeafeonParentMom_FailSafe()
		{
			LeafeonParentMom_FailSafe.LoadFailSafeLeafeonParentMom_AnimatorController();
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult
{
	public class LFS_DragapultParentsFailSafe : MonoBehaviour 
	{
		private DragapultParentDad_FailSafe DragapultParentDad_FailSafe;
		private DragapultParentMom_FailSafe DragapultParentMom_FailSafe;
		public void Load_DragapultParentsFailSafe()
		{
			Load_DragapultParentDad_FailSafe();
			Load_DragapultParentMom_FailSafe();	
		}
		private void Load_DragapultParentDad_FailSafe()
		{
			DragapultParentDad_FailSafe.LoadFailSafeDragapultParentDad_AnimatorController();
		}
		private void Load_DragapultParentMom_FailSafe()
		{
			DragapultParentMom_FailSafe.LoadFailSafeDragapultParentMom_AnimatorController();
		}
	}
}
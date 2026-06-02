using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToRun
{
	public class VEParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VEParentMom_IdleToRunController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
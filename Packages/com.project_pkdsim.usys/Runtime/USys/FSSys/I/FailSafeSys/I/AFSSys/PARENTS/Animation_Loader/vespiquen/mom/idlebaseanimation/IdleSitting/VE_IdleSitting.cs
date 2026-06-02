using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation.IdleSitting
{
	public class VEParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VEParentMom_IdleSittingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
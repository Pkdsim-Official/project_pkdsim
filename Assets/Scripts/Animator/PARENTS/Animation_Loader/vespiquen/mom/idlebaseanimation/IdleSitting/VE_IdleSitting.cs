using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation.IdleSitting
{
	public class VEParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator VespiquenParentMom_Animator;
		public void VEParentMom_IdleSittingController()
		{
			VespiquenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
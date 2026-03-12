using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToRun
{
	public class VEParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator VespiquenParentMom_Animator;
		public void VEParentMom_IdleToRunController()
		{
			VespiquenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
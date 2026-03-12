using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation.IdleSitting
{
	public class LOParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator LopunnyParentMom_Animator;
		public void LOParentMom_IdleSittingController()
		{
			LopunnyParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LopunnyParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleSitting
{
	public class JTParentMom_IdleSitting : MonoBehaviour 
	{
		public Animator JolteonParentMom_Animator;
		public void JTParentMom_IdleSittingController()
		{
			JolteonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
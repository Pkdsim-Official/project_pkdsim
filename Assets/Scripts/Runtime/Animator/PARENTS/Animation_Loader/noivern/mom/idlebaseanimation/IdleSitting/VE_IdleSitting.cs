using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation.IdleSitting
{
	public class NOIParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator NoivernParentMom_Animator;
		public void NOIParentMom_IdleSittingController()
		{
			NoivernParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			NoivernParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Primarina.idlebaseanimation.IdleSitting
{
	public class PRIdleSitting : MonoBehaviour 
	{
		private Animator PrimarinaParentDad_Animator;
		public void PRIdleSittingController()
		{
			PrimarinaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PrimarinaParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
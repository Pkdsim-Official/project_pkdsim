using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation.IdleSitting
{
	public class VPParentDad_IdleSitting : MonoBehaviour 
	{
		public Animator VaporeonParentDad_Animator;
		public void VPParentDad_IdleSittingController()
		{
			VaporeonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VaporeonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
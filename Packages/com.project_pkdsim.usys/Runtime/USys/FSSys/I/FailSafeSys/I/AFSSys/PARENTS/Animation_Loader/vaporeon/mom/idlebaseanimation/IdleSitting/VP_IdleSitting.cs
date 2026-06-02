using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation.IdleSitting
{
	public class VPParentMom_IdleSitting : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public void VPParentMom_IdleSittingController()
		{
			Vaporeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vaporeon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
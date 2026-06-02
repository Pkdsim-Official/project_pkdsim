using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation.IdleSitting
{
	public class VPParentDad_IdleSitting : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public void VPParentDad_IdleSittingController()
		{
			Vaporeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vaporeon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
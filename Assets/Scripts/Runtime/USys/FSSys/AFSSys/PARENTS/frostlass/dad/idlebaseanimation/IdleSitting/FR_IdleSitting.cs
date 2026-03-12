using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.idlebaseanimation.IdleSitting
{
	public class FRIdleSitting : MonoBehaviour 
	{
		private Animator FrostlassParentDad_Animator;
		public void FRIdleSittingController()
		{
			FrostlassParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FrostlassParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
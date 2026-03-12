using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleSitting
{
	public class ABIdleSitting : MonoBehaviour 
	{
		private Animator AbsolParentDad_Animator;
		public void ABIdleSittingController()
		{
			AbsolParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			AbsolParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
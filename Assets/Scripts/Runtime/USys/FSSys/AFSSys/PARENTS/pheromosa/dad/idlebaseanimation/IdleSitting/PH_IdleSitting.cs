using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.idlebaseanimation.IdleSitting
{
	public class PHParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator PheromosaParentDad_Animator;
		public void PHParentDad_IdleSittingController()
		{
			PheromosaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.idlebaseanimation.IdleSitting
{
	public class PHIdleSitting : MonoBehaviour 
	{
		private Animator PheromosaParentDad_Animator;
		public void PHIdleSittingController()
		{
			PheromosaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
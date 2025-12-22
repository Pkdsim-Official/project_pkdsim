using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.idlebaseanimation.IdleSitting
{
	public class ZParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator ZoroarkParentDad_Animator;
		public void ZParentDad_IdleSittingController()
		{
			ZoroarkParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			ZoroarkParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
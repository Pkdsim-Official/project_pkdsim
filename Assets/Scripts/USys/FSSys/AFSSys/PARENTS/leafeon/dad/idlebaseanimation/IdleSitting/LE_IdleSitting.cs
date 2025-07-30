using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation.IdleSitting
{
	public class LEParentDad_IdleSitting : MonoBehaviour 
	{
		public Animator LeafeonParentDad_Animator;
		public void LEParentDad_IdleSittingController()
		{
			LeafeonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
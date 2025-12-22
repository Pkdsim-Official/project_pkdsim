using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation.IdleStanding
{
	public class LEParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator LeafeonParentDad_Animator;
		public void LEParentDad_IdleStandingController()
		{
			LeafeonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
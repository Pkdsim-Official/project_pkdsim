using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.idlebaseanimation.IdleStanding
{
	public class DRIdleStanding : MonoBehaviour 
	{
		public Animator DragapultParentDad_Animator;
		public void DRIdleStandingController()
		{
			// Assign the idle animation clip
			DragapultParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DragapultParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
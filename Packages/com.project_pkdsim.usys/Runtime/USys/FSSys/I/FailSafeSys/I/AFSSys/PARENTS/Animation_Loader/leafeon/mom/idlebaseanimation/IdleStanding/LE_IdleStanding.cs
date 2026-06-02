using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleStanding
{
	public class LE_IdleStanding : MonoBehaviour 
	{
		public Animator LeafeonParentMom_Animator;
		public void LE_IdleStandingController()
		{
			LeafeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
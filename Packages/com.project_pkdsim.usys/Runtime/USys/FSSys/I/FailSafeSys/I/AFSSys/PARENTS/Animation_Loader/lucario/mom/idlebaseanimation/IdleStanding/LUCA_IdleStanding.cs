using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation.IdleStanding
{
	public class LUCAParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator Lucario_Animator;
		public void LUCAParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			Lucario_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lucario_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.idlebaseanimation.IdleStanding
{
	public class LUCAParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator LucarioParentDad_Animator;
		public void LUCAParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			LucarioParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LucarioParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
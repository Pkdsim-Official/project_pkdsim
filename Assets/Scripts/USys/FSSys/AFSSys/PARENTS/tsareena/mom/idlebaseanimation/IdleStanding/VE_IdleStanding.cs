using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleStanding
{
	public class TParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator TsareenaParentMom_Animator;
		public void TParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			TsareenaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			TsareenaParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
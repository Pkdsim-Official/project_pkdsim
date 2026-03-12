using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.idlebaseanimation.IdleStanding
{
	public class TParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator TsareenaParentDad_Animator;
		public void TParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			TsareenaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			TsareenaParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
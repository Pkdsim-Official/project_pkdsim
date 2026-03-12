using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Zoroark.idlebaseanimation.IdleStanding
{
	public class Z_IdleStanding : MonoBehaviour 
	{
		public Animator Zoroark_Animator;
		public void Z_IdleStandingController()
		{
			// Assign the idle animation clip
			Zoroark_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Zoroark_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
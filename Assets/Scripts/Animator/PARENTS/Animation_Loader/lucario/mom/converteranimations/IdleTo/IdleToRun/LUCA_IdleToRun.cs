using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo.IdleToRun
{
	public class LUCAParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator LucarioParentMom_Animator;
		public void LUCAParentMom_IdleToRunController()
		{
			LucarioParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LucarioParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
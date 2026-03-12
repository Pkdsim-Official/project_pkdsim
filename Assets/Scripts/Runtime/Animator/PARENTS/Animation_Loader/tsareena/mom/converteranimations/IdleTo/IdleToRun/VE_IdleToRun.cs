using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo.IdleToRun
{
	public class TParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator TsareenaParentMom_Animator;
		public void TParentMom_IdleToRunController()
		{
			TsareenaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			TsareenaParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
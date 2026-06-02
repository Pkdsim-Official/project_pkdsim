using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleSitting
{
	public class TParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator TsareenaParentMom_Animator;
		public void TParentMom_IdleSittingController()
		{
			TsareenaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			TsareenaParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
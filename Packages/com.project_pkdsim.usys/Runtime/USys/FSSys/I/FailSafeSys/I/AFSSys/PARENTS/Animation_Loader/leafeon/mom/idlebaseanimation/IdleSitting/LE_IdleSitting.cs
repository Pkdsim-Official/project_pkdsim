using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleSitting
{
	public class LE_IdleSitting : MonoBehaviour 
	{
		public Animator LeafeonParentMom_Animator;
		public void LE_IdleSittingController()
		{
			LeafeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
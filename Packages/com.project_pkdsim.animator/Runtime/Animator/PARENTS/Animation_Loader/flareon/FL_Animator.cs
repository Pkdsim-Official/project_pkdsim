using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon
{
	public class FLParent_Animator : MonoBehaviour 
	{
		public Animator Flareon_Animator;
		public RuntimeAnimatorController someController;

		private void Flareon_AnimatorController()
		{
			Flareon_Animator = gameObject.GetComponent<Animator>();
			Flareon_Animator.runtimeAnimatorController = someController;
		}
	}
}
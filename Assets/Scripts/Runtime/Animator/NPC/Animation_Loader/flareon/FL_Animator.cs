using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Flareon
{
	public class FL_Animator : MonoBehaviour 
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
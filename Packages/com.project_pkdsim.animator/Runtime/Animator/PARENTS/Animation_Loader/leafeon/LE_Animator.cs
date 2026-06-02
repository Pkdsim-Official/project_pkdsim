using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeo
{
	public class LEParent_Animator : MonoBehaviour 
	{
		public Animator Leafeon_Animator;
		public RuntimeAnimatorController someController;
		private void Leafeon_AnimatorController()
		{
			Leafeon_Animator = gameObject.GetComponent<Animator>();
			Leafeon_Animator.runtimeAnimatorController = someController;
		}
	}
}
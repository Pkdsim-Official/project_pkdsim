using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Espeon
{
	public class LE_Animator : MonoBehaviour 
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
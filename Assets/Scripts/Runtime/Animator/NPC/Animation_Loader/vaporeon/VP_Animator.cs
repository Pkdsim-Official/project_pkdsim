using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vaporeon
{
	public class VAPOR_Animator : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public RuntimeAnimatorController someController;	
		private void Vaporeon_AnimatorController()
		{
			Vaporeon_Animator = gameObject.GetComponent<Animator>();
			Vaporeon_Animator.runtimeAnimatorController = someController;
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.Animator_I
{
	public class LucarioFailSafe : MonoBehaviour 
	{
		public Animator Lucario_Animator;
		public RuntimeAnimatorController someController;

		private Lucario_ConverterToAnimatorController Lucario_AnimatorCCA;
		private LucarioParent_AnimatorMovementController Lucario_AnimatorCMA;
		private Lucario_IdleAnimatorController Lucario_AnimatorICA;


		public void LoadFailSafeLucario_AnimatorController()
		{
			LoadFailSafeLucario_ConvertToAnimatorController();
			LoadFailSafeLucario_MovementAnimatorController();
			LoadFailSafeLucario_IdleAnimatorController();
		}
		private void LoadFailSafeLucario_ConvertToAnimatorController()
		{
			Lucario_AnimatorCCA.LUCA_ConverterToAnimatorController();
		}
		private void LoadFailSafeLucario_MovementAnimatorController()
		{
			Lucario_AnimatorCMA.LUCAMovementAnimatorController();
		}
		private void LoadFailSafeLucario_IdleAnimatorController()
		{
			Lucario_AnimatorICA.LUCA_IdleAnimatorController();
		}
	}
}
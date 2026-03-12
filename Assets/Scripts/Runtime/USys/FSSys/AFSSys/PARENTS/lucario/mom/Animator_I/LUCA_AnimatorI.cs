using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.Animator_I
{
	public class LFS_LucarioFailSafe : MonoBehaviour
	{
		public Animator lucarioParentMom_Animator;
		public RuntimeAnimatorController someController;

		private LucarioParentMom_ConverterAnimatorController LFSLucario_AnimatorCCA;
		private LucarioParentMom_MovementAnimatorController LFSLucario_AnimatorCMA;
		private LucarioParentMom_IdleAnimatorController LFSLucario_AnimatorICA;


		public void LoadFailSafeLucario_AnimatorController()
		{
			LoadFailSafeLucario_ConvertToAnimatorController();
			LoadFailSafeLucario_MovementAnimatorController();
			LoadFailSafeLucario_IdleAnimatorController();
		}
		private void LoadFailSafeLucario_ConvertToAnimatorController()
		{
			LFSLucario_AnimatorCCA.LUCAParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeLucario_MovementAnimatorController()
		{
			LFSLucario_AnimatorCMA.LUCAParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeLucario_IdleAnimatorController()
		{
			LFSLucario_AnimatorICA.LUCAParentMom_IdleAnimatorController();
		}
	}
}
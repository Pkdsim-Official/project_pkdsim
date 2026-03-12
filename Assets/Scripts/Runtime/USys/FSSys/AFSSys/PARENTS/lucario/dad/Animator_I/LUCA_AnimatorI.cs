using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.Animator_I
{
	public class LFS_LucarioFailSafe : MonoBehaviour 
	{
		public Animator LucarioParentDad_Animator;
		public RuntimeAnimatorController someController;

		private LucarioParentDad_ConverterAnimatorController LFSLucario_AnimatorCCA;
		private LucarioParentDad_MovementAnimatorController LFSLucario_AnimatorCMA;
		private LucarioParentDad_IdleAnimatorController LFSLucario_AnimatorICA;


		public void LoadFailSafeLucario_AnimatorController()
		{
			LoadFailSafeLucario_ConvertToAnimatorController();
			LoadFailSafeLucario_MovementAnimatorController();
			LoadFailSafeLucario_IdleAnimatorController();
		}
		private void LoadFailSafeLucario_ConvertToAnimatorController()
		{
			LFSLucario_AnimatorCCA.LUCAParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeLucario_MovementAnimatorController()
		{
			LFSLucario_AnimatorCMA.LUCAParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeLucario_IdleAnimatorController()
		{
			LFSLucario_AnimatorICA.LUCAParentDad_IdleAnimatorController();
		}
	}
}
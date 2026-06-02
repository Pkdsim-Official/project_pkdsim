using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.Animator_I
{
	public class LucarioParentDad_FailSafe : MonoBehaviour 
	{
		public Animator LucarioParent_Animator;
		public RuntimeAnimatorController someController;

		private LucarioParentDad_ConverterAnimatorController LucarioParent_AnimatorCCA;
		private LucarioParentDad_MovementAnimatorController LucarioParent_AnimatorCMA;
		private LucarioParentDad_IdleAnimatorController LucarioParent_AnimatorICA;


		public void LoadFailSafeLucarioParentDad_AnimatorController()
		{
			LoadFailSafeLucarioParent_ConvertToAnimatorController();
			LoadFailSafeLucarioParent_MovementAnimatorController();
			LoadFailSafeLucarioParent_IdleAnimatorController();
		}
		private void LoadFailSafeLucarioParent_ConvertToAnimatorController()
		{
			LucarioParent_AnimatorCCA.LUCAParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeLucarioParent_MovementAnimatorController()
		{
			LucarioParent_AnimatorCMA.LUCAParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeLucarioParent_IdleAnimatorController()
		{
			LucarioParent_AnimatorICA.LUCAParentDad_IdleAnimatorController();
		}
	}
}
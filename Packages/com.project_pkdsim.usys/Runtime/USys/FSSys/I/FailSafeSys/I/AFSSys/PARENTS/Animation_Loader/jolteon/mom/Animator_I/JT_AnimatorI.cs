using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.Animator_I
{
	public class JolteonParentMom_FailSafe : MonoBehaviour 
	{
		public Animator JolteonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private JolteonParentMom_ConverterAnimatorController JolteonParentMom_AnimatorCCA;
		private JolteonParentMom_MovementAnimatorController JolteonParentMom_AnimatorCMA;
		private JolteonParentMom_IdleAnimatorController JolteonParentMom_AnimatorICA;

		public void LoadFailSafeJolteonParentMom_AnimatorController()
		{
			JolteonParentMom_ConvertToAnimatorController();
			JolteonParentMom_MovementAnimatorController();
			JolteonParentMom_IdleAnimatorController();
		}
		private void JolteonParentMom_ConvertToAnimatorController()
		{
			JolteonParentMom_AnimatorCCA.JTParentMom_ConverterAnimatorController();
		}
		private void JolteonParentMom_MovementAnimatorController()
		{
			JolteonParentMom_AnimatorCMA.JTParentMom_MovementAnimatorController();
		}
		private void JolteonParentMom_IdleAnimatorController()
		{
			JolteonParentMom_AnimatorICA.JTParentMom_IdleAnimatorController();
		}
	}
}
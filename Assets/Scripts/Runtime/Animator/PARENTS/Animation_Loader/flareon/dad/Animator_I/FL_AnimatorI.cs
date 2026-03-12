using Project_Pkdsim.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Dad.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Flareon.Dad.Animator_I
{
	public class LFS_FlareonFailSafe : MonoBehaviour 
	{
		private FlareonParentDad_ConverterAnimatorController LFSFlareon_AnimatorCCA;
		private FlareonParentDad_MovementAnimatorController LFSFlareon_AnimatorCMA;
		private FlareonParentDad_IdleAnimatorController LFSFlareon_AnimatorICA;


		public void LoadFailSafeFlareonParentDad_AnimatorController()
		{
			LoadFailSafeFlareon_ConvertToAnimatorController();
			LoadFailSafeFlareon_MovementAnimatorController();
			LoadFailSafeFlareon_IdleAnimatorController();
		}
		private void LoadFailSafeFlareon_ConvertToAnimatorController()
		{
			LFSFlareon_AnimatorCCA.FLParentDadDad_ConverterAnimatorController();
		}
		private void LoadFailSafeFlareon_MovementAnimatorController()
		{
			LFSFlareon_AnimatorCMA.FLParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeFlareon_IdleAnimatorController()
		{
			LFSFlareon_AnimatorICA.FLParentDadDad_IdleAnimatorController();
		}
	}
}
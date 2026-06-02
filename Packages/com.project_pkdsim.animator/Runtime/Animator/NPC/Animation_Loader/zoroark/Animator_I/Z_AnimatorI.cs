using project_pkdsim.ANIMATOR.NPC.Zoroark.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Zoroark.Animator_I
{
	public class LFS_ZoroarkFailSafe : MonoBehaviour 
	{
		public Animator Zoroark_Animator;
		public RuntimeAnimatorController someController;
		private NPCSpeciesType zoroark = NPCSpeciesType.ZOROARK;

		private Zoroark_ConverterAnimatorController LFSZoroark_AnimatorCCA;
		private Zoroark_MovementAnimatorController LFSZoroark_AnimatorCMA;
		private Zoroark_IdleAnimatorController LFSZoroark_AnimatorICA;


		public void LoadFailSafeZoroark_AnimatorController()
		{
			LoadFailSafeZoroark_ConvertToAnimatorController();
			LoadFailSafeZoroark_MovementAnimatorController();
			LoadFailSafeZoroark_IdleAnimatorController();
		}
		private void LoadFailSafeZoroark_ConvertToAnimatorController()
		{
			LFSZoroark_AnimatorCCA.Z_ConverterAnimatorController();
		}
		private void LoadFailSafeZoroark_MovementAnimatorController()
		{
			LFSZoroark_AnimatorCMA.ZMovementAnimatorController();
		}
		private void LoadFailSafeZoroark_IdleAnimatorController()
		{
			LFSZoroark_AnimatorICA.Z_IdleAnimatorController();
		}
	}
}
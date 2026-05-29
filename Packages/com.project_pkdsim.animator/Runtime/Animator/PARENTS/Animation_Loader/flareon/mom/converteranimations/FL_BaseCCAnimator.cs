using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo;

using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations
{
	public class FlareonParentMom_AnimatorConverterController : MonoBehaviour 
	{
		private FL_IdleTo FlareonParentMom_idleto;
		
		private FL_WalkingTo FlareonParentMom_walkingto;

		private FL_SittingTo FlareonParentMom_sittingto;
		private void FlareonParentMom_Base_IdleAnimatorController()
		{
			FlareonParentMom_walkingto.FL_WalkingToController();

			FlareonParentMom_idleto.FL_IdleToController();
			
			FlareonParentMom_sittingto.FL_SittingToController();
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.converteranimations.IdleTo;

using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.converteranimations
{
	public class FlareonParentDad_AnimatorConverterController : MonoBehaviour 
	{
		private FL_IdleTo FlareonParentDad_idleto;
		
		private FL_WalkingTo FlareonParentDad_walkingto;

		private FL_SittingTo FlareonParentDad_sittingto;
		private void FlareonParentDad_Base_IdleAnimatorController()
		{
			FlareonParentDad_walkingto.FL_WalkingToController();

			FlareonParentDad_idleto.FL_IdleToController();
			
			FlareonParentDad_sittingto.FL_SittingToController();
		}
	}
}
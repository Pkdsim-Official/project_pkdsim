using project_pkdsim.ANIMATOR.Parents.Flareon.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Flareon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Flareon.converteranimations.IdleTo;

using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.converteranimations
{
	public class Flareon_AnimatorConverterController : MonoBehaviour 
	{
		private FL_IdleTo Flareon_idleto;
		
		private FL_WalkingTo Flareon_walkingto;

		private FL_SittingTo Flareon_sittingto;
		private void Flareon_Base_IdleAnimatorController()
		{
			Flareon_walkingto.FL_WalkingToController();

			Flareon_idleto.FL_IdleToController();
			
			Flareon_sittingto.FL_SittingToController();
		}
	}
}
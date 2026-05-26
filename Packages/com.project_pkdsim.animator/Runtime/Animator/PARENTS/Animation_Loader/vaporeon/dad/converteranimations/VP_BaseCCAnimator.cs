using project_pkdsim.ANIMATOR.Parents.Vaporeon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.converteranimations
{
	public class Vaporeon_CoverterAnimatorController : MonoBehaviour 
	{
		private VP_SittingTo Vaporeon_sittingto;
		
		private VP_WalkingTo Vaporeon_walkingto;
		
		private VP_IdleTo Vaporeon_idleto;

		private void VP_Base_IdleAnimatorController()
		{
			Vaporeon_walkingto.VP_WalkingToController();

			Vaporeon_idleto.VP_IdleToController();
			
			Vaporeon_sittingto.VP_SittingToController();	
		}
	}
}
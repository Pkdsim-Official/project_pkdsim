using project_pkdsim.ANIMATOR.Parents.Umbreon.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Umbreon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Umbreon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.converteranimations
{
	public class Umbreon_AnimatorBaseConverterController : MonoBehaviour 
	{
		private UM_SittingTo Umbreon_sittingto;
		
		private UM_WalkingTo Umbreon_walkingto;
		
		private UM_IdleTo Umbreon_idleto;

		private void UM_Base_IdleAnimatorController()
		{
			Umbreon_walkingto.UM_WalkingToController();

			Umbreon_idleto.UM_IdleToController();
			
			Umbreon_sittingto.UM_SittingToController();	
		}
	}
}
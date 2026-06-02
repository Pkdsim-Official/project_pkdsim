using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations
{
	public class Umbreon_ConverterAnimatorController : MonoBehaviour 
	{
		private UM_SittingTo Umbreon_sittingto;
		
		private UM_WalkingTo Umbreon_walkingto;
		
		private UM_IdleTo Umbreon_idleto;

		private void UMParentMom_IdleAnimatorController()
		{
			Umbreon_walkingto.UM_WalkingToController();

			Umbreon_idleto.UM_IdleToController();
			
			Umbreon_sittingto.UM_SittingToController();	
		}
	}
}
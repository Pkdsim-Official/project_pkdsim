using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations
{
	public class FlareonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private FLParentMom_IdleTo FlareonParentMom_idleto;
		
		private FLParentMom_WalkingTo FlareonParentMom_walkingto;

		private FLParentMom_SittingTo FlareonParentMom_sittingto;
		public void FLParentMom_ConverterAnimatorController()
		{
			FlareonParentMom_walkingto.FLParentMom_WalkingToController();

			FlareonParentMom_idleto.FLParentMom_IdleToController();
			
			FlareonParentMom_sittingto.FLParentMom_SittingToController();
		}
	}
}
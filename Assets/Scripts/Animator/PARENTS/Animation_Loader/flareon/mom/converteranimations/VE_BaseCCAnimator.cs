using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations
{
	public class FlareonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private FLParentMom_SittingTo FlareonParentMomSittingto;
		
		private FLParentMom_WalkingTo FlareonParentMomWalkingto;
		
		private FLParentMom_IdleTo FlareonParentMomIdleto;

		public void FLParentMom_ConverterAnimatorController()
		{
			FlareonParentMomWalkingto.FLParentMom_WalkingToController();

			FlareonParentMomIdleto.FLParentMom_IdleToController();
			
			FlareonParentMomSittingto.FLParentMom_SittingToController();	
		}
	}
}
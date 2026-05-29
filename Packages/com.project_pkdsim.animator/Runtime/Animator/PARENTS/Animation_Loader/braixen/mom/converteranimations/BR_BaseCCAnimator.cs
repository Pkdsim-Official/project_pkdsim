using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations
{
	public class BraixenParentMom_ConverterToAnimatorController : MonoBehaviour 
	{
		private BRSittingTo BraixenSittingto;
		
		private BR_WalkingTo BraixenWalkingto;
		
		private BR_IdleTo BraixenIdleto;

		public void BR_ConverterToAnimatorController()
		{
			BraixenWalkingto.BR_WalkingToController();

			BraixenIdleto.BR_IdleToController();
			
			BraixenSittingto.BRSittingToController();	
		}
	}
}
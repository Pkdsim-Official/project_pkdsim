using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations
{
	public class BraixenParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private BRSittingTo BraixenSittingto;
		
		private BR_WalkingTo BraixenWalkingto;
		
		private BR_IdleTo BraixenIdleto;

		public void BR_ConverterAnimatorController()
		{
			BraixenWalkingto.BR_WalkingToController();

			BraixenIdleto.BR_IdleToController();
			
			BraixenSittingto.BRSittingToController();	
		}
	}
}
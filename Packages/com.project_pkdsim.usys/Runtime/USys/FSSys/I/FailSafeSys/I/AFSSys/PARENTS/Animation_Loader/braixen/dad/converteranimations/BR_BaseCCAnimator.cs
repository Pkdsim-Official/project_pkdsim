using project_pkdsim.ANIMATOR.Parents.Braixen.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Braixen.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Braixen.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.converteranimations
{
	public class Braixen_ConverterToAnimatorController : MonoBehaviour 
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
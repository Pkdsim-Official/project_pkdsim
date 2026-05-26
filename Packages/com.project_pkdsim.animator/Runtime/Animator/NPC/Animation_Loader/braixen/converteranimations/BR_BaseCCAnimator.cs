using project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations
{
	public class BraixenCoverterAnimatorController : MonoBehaviour 
	{
		private BR_SittingTo BraixenSittingto;
		
		private BR_WalkingTo BraixenWalkingto;
		
		private BR_IdleTo BraixenIdleto;

		public void BRCoverterToAnimatorController()
		{
			BraixenWalkingto.BR_WalkingToController();

			BraixenIdleto.BR_IdleToController();
			
			BraixenSittingto.BR_SittingToController();	
		}
	}
}
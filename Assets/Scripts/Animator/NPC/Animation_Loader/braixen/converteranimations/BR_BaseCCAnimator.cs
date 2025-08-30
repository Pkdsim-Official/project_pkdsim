using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations
{
	public class BraixenCoverterAnimatorController : MonoBehaviour 
	{
		private BRSittingTo Braixensittingto;
		
		private BRWalkingTo Braixenwalkingto;
		
		private BRIdleTo Braixenidleto;

		public void BRCoverterToAnimatorController()
		{
			Braixenwalkingto.BRWalkingToController();

			Braixenidleto.BRIdleToController();
			
			Braixensittingto.BRSittingToController();	
		}
	}
}
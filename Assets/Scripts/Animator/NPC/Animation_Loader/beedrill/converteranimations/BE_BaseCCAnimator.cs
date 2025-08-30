using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations
{
	public class BeedrillCoverterAnimatorController : MonoBehaviour 
	{
		private BESittingTo Beedrillsittingto;
		
		private BEWalkingTo Beedrillwalkingto;
		
		private BEIdleTo Beedrillidleto;

		public void BECoverterToAnimatorController()
		{
			Beedrillwalkingto.BEWalkingToController();

			Beedrillidleto.BEIdleToController();
			
			Beedrillsittingto.BESittingToController();	
		}
	}
}
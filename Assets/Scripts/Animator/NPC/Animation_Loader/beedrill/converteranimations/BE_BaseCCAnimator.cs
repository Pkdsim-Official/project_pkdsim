using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations
{
	public class BeedrillCoverterAnimatorController : MonoBehaviour 
	{
		private BE_SittingTo BeedrillSittingto;
		
		private BE_WalkingTo BeedrillWalkingto;
		
		private BE_IdleTo BeedrillIdleto;

		public void BE_CoverterToAnimatorController()
		{
			BeedrillWalkingto.BE_WalkingToController();

			BeedrillIdleto.BE_IdleToController();
			
			BeedrillSittingto.BE_SittingToController();	
		}
	}
}
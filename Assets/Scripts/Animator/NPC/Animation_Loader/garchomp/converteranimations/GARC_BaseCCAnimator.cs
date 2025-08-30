using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations
{
	public class GarchompCoverterAnimatorController : MonoBehaviour 
	{
		private GARCSittingTo Garchompsittingto;
		
		private GARCWalkingTo Garchompwalkingto;
		
		private GARCIdleTo Garchompidleto;

		public void GARCCoverterToAnimatorController()
		{
			Garchompwalkingto.GARCWalkingToController();

			Garchompidleto.GARCIdleToController();
			
			Garchompsittingto.GARCSittingToController();	
		}
	}
}
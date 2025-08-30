using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations
{
	public class FrostlassCoverterAnimatorController : MonoBehaviour 
	{
		private FRSittingTo Frostlasssittingto;
		
		private FRWalkingTo Frostlasswalkingto;
		
		private FRIdleTo Frostlassidleto;

		public void FRCoverterToAnimatorController()
		{
			Frostlasswalkingto.FRWalkingToController();

			Frostlassidleto.FRIdleToController();
			
			Frostlasssittingto.FRSittingToController();	
		}
	}
}
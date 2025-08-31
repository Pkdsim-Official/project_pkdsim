using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations
{
	public class FrostlassCoverterAnimatorController : MonoBehaviour 
	{
		private FR_SittingTo FrostlassSittingto;
		
		private FR_WalkingTo FrostlassWalkingto;
		
		private FR_IdleTo FrostlassIdleto;

		public void FRCoverterToAnimatorController()
		{
			FrostlassWalkingto.FR_WalkingToController();

			FrostlassIdleto.FR_IdleToController();
			
			FrostlassSittingto.FR_SittingToController();	
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Frostlass.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Frostlass.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Frostlass.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.converteranimations
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
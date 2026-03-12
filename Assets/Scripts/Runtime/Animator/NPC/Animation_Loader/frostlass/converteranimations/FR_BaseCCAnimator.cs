using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations
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
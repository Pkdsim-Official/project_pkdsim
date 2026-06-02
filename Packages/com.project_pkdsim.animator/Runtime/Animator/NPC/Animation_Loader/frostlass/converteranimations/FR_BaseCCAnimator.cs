using project_pkdsim.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Frostlass.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Frostlass.converteranimations
{
	public class Frostlass_ConverterAnimatorController : MonoBehaviour 
	{
		private FR_SittingTo FrostlassSittingto;
		
		private FR_WalkingTo FrostlassWalkingto;
		
		private FR_IdleTo FrostlassIdleto;

		public void FR_ConverterAnimatorController()
		{
			FrostlassWalkingto.FR_WalkingToController();

			FrostlassIdleto.FR_IdleToController();
			
			FrostlassSittingto.FR_SittingToController();	
		}
	}
}
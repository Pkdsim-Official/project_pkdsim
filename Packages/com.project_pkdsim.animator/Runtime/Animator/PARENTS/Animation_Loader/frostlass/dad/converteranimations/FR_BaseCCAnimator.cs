using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadconverteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadconverteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadconverteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadconverteranimations
{
	public class FrostlassParentDad_ConverterToAnimatorController : MonoBehaviour 
	{
		private FR_SittingTo FrostlassSittingto;
		
		private FR_WalkingTo FrostlassWalkingto;
		
		private FR_IdleTo FrostlassIdleto;

		public void FR_ConverterToAnimatorController()
		{
			FrostlassWalkingto.FR_WalkingToController();

			FrostlassIdleto.FR_IdleToController();
			
			FrostlassSittingto.FR_SittingToController();	
		}
	}
}
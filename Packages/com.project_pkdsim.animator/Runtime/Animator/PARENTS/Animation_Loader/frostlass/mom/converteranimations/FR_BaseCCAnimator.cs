using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations
{
	public class FrostlassParentMom_ConverterToAnimatorController : MonoBehaviour 
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
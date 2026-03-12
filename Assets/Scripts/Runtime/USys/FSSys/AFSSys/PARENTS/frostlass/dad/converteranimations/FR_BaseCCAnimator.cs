using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations
{
	public class FrostlassConverterAnimatorController : MonoBehaviour 
	{
		private FR_SittingTo FrostlassSittingto;
		
		private FR_WalkingTo FrostlassWalkingto;
		
		private FR_IdleTo FrostlassIdleto;

		public void FRConverterAnimatorController()
		{
			FrostlassWalkingto.FR_WalkingToController();

			FrostlassIdleto.FR_IdleToController();
			
			FrostlassSittingto.FR_SittingToController();	
		}
	}
}
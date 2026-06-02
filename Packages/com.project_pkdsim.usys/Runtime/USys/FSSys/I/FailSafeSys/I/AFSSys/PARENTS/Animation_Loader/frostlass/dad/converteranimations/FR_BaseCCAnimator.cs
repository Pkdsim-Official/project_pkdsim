using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Dad.converteranimations
{
	public class FrostlassParentDad_ConverterAnimatorController : MonoBehaviour 
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
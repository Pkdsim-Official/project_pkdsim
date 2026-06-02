using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations
{
	public class GarchompParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private GARCParentDad_SittingTo GarchompSittingto;
		
		private GARCParentDad_WalkingTo GarchompWalkingto;
		
		private GARCParentDad_IdleTo GarchompIdleto;

		public void GARCParentDad_ConverterAnimatorController()
		{
			GarchompWalkingto.GARCParentDad_WalkingToController();

			GarchompIdleto.GARCParentDad_IdleToController();
			
			GarchompSittingto.GARCParentDad_SittingToController();	
		}
	}
}
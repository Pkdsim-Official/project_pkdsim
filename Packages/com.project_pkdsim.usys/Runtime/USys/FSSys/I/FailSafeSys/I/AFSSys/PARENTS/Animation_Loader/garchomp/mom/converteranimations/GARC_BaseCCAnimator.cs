using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations
{
	public class GarchompParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private GARCParentMom_SittingTo GarchompSittingto;
		
		private GARCParentMom_WalkingTo GarchompWalkingto;
		
		private GARCParentMom_IdleTo GarchompIdleto;

		public void GARCParentMom_ConverterAnimatorController()
		{
			GarchompWalkingto.GARCParentMom_WalkingToController();

			GarchompIdleto.GARCParentMom_IdleToController();
			
			GarchompSittingto.GARCParentMom_SittingToController();	
		}
	}
}
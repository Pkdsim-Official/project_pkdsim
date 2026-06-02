using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations
{
	public class LopunnyParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private LOParentMom_SittingTo Lopunnysittingto;
		
		private LOParentMom_WalkingTo Lopunnywalkingto;
		
		private LOParentMom_IdleTo Lopunnyidleto;

		public void LOParentMom_ConverterAnimatorController()
		{
			Lopunnywalkingto.LOParentMom_WalkingToController();

			Lopunnyidleto.LOParentMom_IdleToController();
			
			Lopunnysittingto.LOParentMom_SittingToController();	
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations
{
	public class LopunnyParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private LOParentDad_SittingTo Lopunnysittingto;
		
		private LOParentDad_WalkingTo Lopunnywalkingto;
		
		private LOParentDad_IdleTo Lopunnyidleto;

		public void LOParentDad_ConverterAnimatorController()
		{
			Lopunnywalkingto.LOParentDad_WalkingToController();

			Lopunnyidleto.LOParentDad_IdleToController();
			
			Lopunnysittingto.LOParentDad_SittingToController();	
		}
	}
}
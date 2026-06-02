using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations
{
	public class VespiquenParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentDad_SittingTo Vespiquensittingto;
		
		private VEParentDad_WalkingTo Vespiquenwalkingto;
		
		private VEParentDad_IdleTo Vespiquenidleto;

		public void VEParentDad_ConverterAnimatorController()
		{
			Vespiquenwalkingto.VEParentDad_WalkingToController();

			Vespiquenidleto.VEParentDad_IdleToController();
			
			Vespiquensittingto.VEParentDad_SittingToController();	
		}
	}
}
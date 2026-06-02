using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class VespiquenParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VespiquenParentMom_SittingTo Vespiquensittingto;
		
		private VespiquenParentMom_WalkingTo Vespiquenwalkingto;
		
		private VespiquenParentMom_IdleTo Vespiquenidleto;

		public void VEParentMom_ConverterAnimatorController()
		{
			Vespiquenwalkingto.VEParentMom_WalkingToController();

			Vespiquenidleto.VEParentMom_IdleToController();
			
			Vespiquensittingto.VEParentMom_SittingToController();	
		}
	}
}
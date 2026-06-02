using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations
{
	public class SylveonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private SYLParentMom_SittingTo Sylveon_sittingto;
		
		private SYLParentMom_WalkingTo Sylveon_walkingto;
		
		private SYLParentMom_IdleTo Sylveon_idleto;

		public void SYLParentMom_ConverterAnimatorController()
		{
			Sylveon_walkingto.SYLParentMom_WalkingToController();

			Sylveon_idleto.SYLParentMom_IdleToController();
			
			Sylveon_sittingto.SYLParentMom_SittingToController();	
		}
	}
}
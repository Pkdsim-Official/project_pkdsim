using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations
{
	public class SylveonParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private SYLParentDad_SittingTo Sylveon_sittingto;
		
		private SYLParentDad_WalkingTo Sylveon_walkingto;
		
		private SYLParentDad_IdleTo Sylveon_idleto;

		public void SYLParentDad_ConverterAnimatorController()
		{
			Sylveon_walkingto.SYLParentDad_WalkingToController();

			Sylveon_idleto.SYLParentDad_IdleToController();
			
			Sylveon_sittingto.SYLParentDad_SittingToController();	
		}
	}
}
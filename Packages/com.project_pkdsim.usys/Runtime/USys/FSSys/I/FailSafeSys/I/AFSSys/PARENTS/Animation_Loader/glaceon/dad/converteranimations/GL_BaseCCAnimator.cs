using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.WalkingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations
{
	public class GlaceonParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private GLParentDad_IdleTo GlaceonParentDad_idleto;
		
		private GLParentDad_WalkingTo GlaceonParentDad_walkingto;

		private GLParentDad_SittingTo GlaceonParentDad_sittingto;
		public void GLParentDad_ConverterAnimatorController()
		{
			GlaceonParentDad_walkingto.GLParentDad_WalkingToController();

			GlaceonParentDad_idleto.GLParentDad_IdleToController();
			
			GlaceonParentDad_sittingto.GLParentDad_SittingToController();	
		}
	}
}
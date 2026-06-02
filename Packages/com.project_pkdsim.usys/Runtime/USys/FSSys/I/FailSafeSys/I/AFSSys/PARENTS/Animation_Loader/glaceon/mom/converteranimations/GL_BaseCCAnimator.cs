using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.WalkingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations
{
	public class GlaceonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private GLParentMom_IdleTo GlaceonParentMom_idleto;
		
		private GLParentMom_WalkingTo GlaceonParentMom_walkingto;

		private GLParentMom_SittingTo GlaceonParentMom_sittingto;
		public void GLParentMom_ConverterAnimatorController()
		{
			GlaceonParentMom_walkingto.GLParentMom_WalkingToController();

			GlaceonParentMom_idleto.GLParentMom_IdleToController();
			
			GlaceonParentMom_sittingto.GLParentMom_SittingToController();	
		}
	}
}
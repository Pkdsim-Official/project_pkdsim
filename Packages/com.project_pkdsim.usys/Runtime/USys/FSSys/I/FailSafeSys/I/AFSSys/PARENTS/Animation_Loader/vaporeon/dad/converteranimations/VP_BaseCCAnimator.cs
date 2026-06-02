using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.WalkingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations
{
	public class VaporeonParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private VPParentDad_SittingTo Vaporeon_sittingto;
		
		private VPParentDad_WalkingTo Vaporeon_walkingto;
		
		private VPParentDad_IdleTo Vaporeon_idleto;

		public void VPParentDad_ConverterAnimatorController()
		{
			Vaporeon_walkingto.VPParentDad_WalkingToController();

			Vaporeon_idleto.VPParentDad_IdleToController();
			
			Vaporeon_sittingto.VPParentDad_SittingToController();	
		}
	}
}
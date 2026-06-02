using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.IdleTo;
using UnityEngine;


namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations
{
	public class VaporeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VPParentMom_SittingTo Vaporeon_sittingto;
		
		private VPParentMom_WalkingTo Vaporeon_walkingto;
		
		private VPParentMom_IdleTo Vaporeon_idleto;

		public void VPParentMom_ConverterAnimatorController()
		{
			Vaporeon_walkingto.VPParentMom_WalkingToController();

			Vaporeon_idleto.VPParentMom_IdleToController();
			
			Vaporeon_sittingto.VPParentMom_SittingToController();	
		}
	}
}
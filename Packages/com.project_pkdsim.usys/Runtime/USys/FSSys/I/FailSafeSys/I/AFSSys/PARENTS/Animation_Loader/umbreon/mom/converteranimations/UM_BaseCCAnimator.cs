using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.WalkingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations
{
	public class UmbreonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private UMParentMom_SittingTo UmbreonParentMom_sittingto;
		
		private UMParentMom_WalkingTo UmbreonParentMom_walkingto;
		
		private UMParentMom_IdleTo UmbreonParentMom_idleto;

		public void UMParentMom_ConverterAnimatorController()
		{
			UmbreonParentMom_walkingto.UMParentMom_WalkingToController();

			UmbreonParentMom_idleto.UMParentMom_IdleToController();
			
			UmbreonParentMom_sittingto.UMParentMom_SittingToController();	
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.converteranimations.WalkingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.converteranimations
{
	public class UmbreonParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private UMParentDad_SittingTo UmbreonParentDad_sittingto;
		
		private UMParentDad_WalkingTo UmbreonParentDad_walkingto;
		
		private UMParentDad_IdleTo UmbreonParentDad_idleto;

		public void UMParentDad_ConverterAnimatorController()
		{
			UmbreonParentDad_walkingto.UMParentDad_WalkingToController();

			UmbreonParentDad_idleto.UMParentDad_IdleToController();
			
			UmbreonParentDad_sittingto.UMParentDad_SittingToController();	
		}
	}
}
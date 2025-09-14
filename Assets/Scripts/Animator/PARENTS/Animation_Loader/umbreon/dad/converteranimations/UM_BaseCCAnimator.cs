using project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations
{
	public class UmbreonParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private UMParentDad_SittingTo UmbreonParentDadsittingto;
		
		private UMParentDad_WalkingTo UmbreonParentDadwalkingto;
		
		private UMParentDad_IdleTo UmbreonParentDadidleto;

		public void UMParentDad_ConverterAnimatorController()
		{
			UmbreonParentDadwalkingto.UMParentDad_WalkingToController();

			UmbreonParentDadidleto.UMParentDad_IdleToController();
			
			UmbreonParentDadsittingto.UMParentDad_SittingToController();	
		}
	}
}
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.WalkingTo;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations
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
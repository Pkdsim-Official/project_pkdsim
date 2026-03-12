using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations
{
	public class UmbreonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private UMParentMom_SittingTo UmbreonParentMomSittingto;
		
		private UMParentMom_WalkingTo UmbreonParentMomWalkingto;
		
		private UMParentMom_IdleTo UmbreonParentMomIdleto;

		public void UMParentMom_ConverterAnimatorController()
		{
			UmbreonParentMomWalkingto.UMParentMom_WalkingToController();

			UmbreonParentMomIdleto.UMParentMom_IdleToController();
			
			UmbreonParentMomSittingto.UMParentMom_SittingToController();	
		}
	}
}
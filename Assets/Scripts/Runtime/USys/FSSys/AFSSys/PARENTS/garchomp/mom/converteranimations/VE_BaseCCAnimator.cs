using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations
{
	public class GarchompParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private GARCParentMom_SittingTo GarchompParentMomSittingto;
		
		private GARCParentMom_WalkingTo GarchompParentMomWalkingto;
		
		private GARCParentMom_IdleTo GarchompParentMomIdleto;

		public void GARCParentMom_ConverterAnimatorController()
		{
			GarchompParentMomWalkingto.GARCParentMom_WalkingToController();

			GarchompParentMomIdleto.GARCParentMom_IdleToController();
			
			GarchompParentMomSittingto.GARCParentMom_SittingToController();	
		}
	}
}
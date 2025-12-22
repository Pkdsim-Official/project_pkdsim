using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations
{
	public class PrimarinaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private PRParentMom_SittingTo PrimarinaParentMomSittingto;
		
		private PRParentMom_WalkingTo PrimarinaParentMomWalkingto;
		
		private PRParentMom_IdleTo PrimarinaParentMomIdleto;

		public void PRParentMom_ConverterAnimatorController()
		{
			PrimarinaParentMomWalkingto.PRParentMom_WalkingToController();

			PrimarinaParentMomIdleto.PRParentMom_IdleToController();
			
			PrimarinaParentMomSittingto.PRParentMom_SittingToController();	
		}
	}
}
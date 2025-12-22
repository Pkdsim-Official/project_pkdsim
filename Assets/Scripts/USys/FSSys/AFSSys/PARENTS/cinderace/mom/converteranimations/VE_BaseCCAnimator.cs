using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations
{
	public class CinderaceParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private CParentMom_SittingTo CinderaceParentMomSittingto;
		
		private CParentMom_WalkingTo CinderaceParentMomWalkingto;
		
		private CParentMom_IdleTo CinderaceParentMomIdleto;

		public void CParentMom_ConverterAnimatorController()
		{
			CinderaceParentMomWalkingto.CParentMom_WalkingToController();

			CinderaceParentMomIdleto.CParentMom_IdleToController();
			
			CinderaceParentMomSittingto.CParentMom_SittingToController();	
		}
	}
}
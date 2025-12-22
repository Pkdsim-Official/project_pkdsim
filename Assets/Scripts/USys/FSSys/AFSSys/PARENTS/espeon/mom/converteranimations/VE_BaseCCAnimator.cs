using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations
{
	public class EspeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private ESParentMom_SittingTo EspeonParentMomSittingto;
		
		private ESParentMom_WalkingTo EspeonParentMomWalkingto;
		
		private ESParentMom_IdleTo EspeonParentMomIdleto;

		public void ESParentMom_ConverterAnimatorController()
		{
			EspeonParentMomWalkingto.ESParentMom_WalkingToController();

			EspeonParentMomIdleto.ESParentMom_IdleToController();
			
			EspeonParentMomSittingto.ESParentMom_SittingToController();	
		}
	}
}
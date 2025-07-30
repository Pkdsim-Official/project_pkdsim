using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations
{
	public class SalazzleParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private SParentMom_SittingTo SalazzleParentMomSittingto;
		
		private SParentMom_WalkingTo SalazzleParentMomWalkingto;
		
		private SParentMom_IdleTo SalazzleParentMomIdleto;

		public void SParentMom_ConverterAnimatorController()
		{
			SalazzleParentMomWalkingto.SParentMom_WalkingToController();

			SalazzleParentMomIdleto.SParentMom_IdleToController();
			
			SalazzleParentMomSittingto.SParentMom_SittingToController();	
		}
	}
}
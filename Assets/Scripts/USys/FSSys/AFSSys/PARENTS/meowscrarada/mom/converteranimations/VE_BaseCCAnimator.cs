using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations
{
	public class MeowscaradaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private MEOWParentMom_SittingTo MeowscaradaParentMomSittingto;
		
		private MEOWParentMom_WalkingTo MeowscaradaParentMomWalkingto;
		
		private MEOWParentMom_IdleTo MeowscaradaParentMomIdleto;

		public void MEOWParentMom_ConverterAnimatorController()
		{
			MeowscaradaParentMomWalkingto.MEOWParentMom_WalkingToController();

			MeowscaradaParentMomIdleto.MEOWParentMom_IdleToController();
			
			MeowscaradaParentMomSittingto.MEOWParentMom_SittingToController();	
		}
	}
}
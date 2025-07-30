using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations
{
	public class NoivernParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private NOIParentMom_SittingTo NoivernParentMomSittingto;
		
		private NOIParentMom_WalkingTo NoivernParentMomWalkingto;
		
		private NOIParentMom_IdleTo NoivernParentMomIdleto;

		public void NOIParentMom_ConverterAnimatorController()
		{
			NoivernParentMomWalkingto.NOIParentMom_WalkingToController();

			NoivernParentMomIdleto.NOIParentMom_IdleToController();
			
			NoivernParentMomSittingto.NOIParentMom_SittingToController();	
		}
	}
}
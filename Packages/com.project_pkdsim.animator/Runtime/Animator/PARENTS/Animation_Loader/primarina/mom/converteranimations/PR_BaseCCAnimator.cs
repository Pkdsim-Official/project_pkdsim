using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Mom.converteranimations
{
	public class PrimarinaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private PRSittingTo Primarinasittingto;
		
		private PRWalkingTo Primarinawalkingto;
		
		private PRIdleTo Primarinaidleto;

		public void PR_ConverterAnimatorController()
		{
			Primarinawalkingto.PRWalkingToController();

			Primarinaidleto.PR_IdleToController();
			
			Primarinasittingto.PRSittingToController();	
		}
	}
}
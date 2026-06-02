using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Dad.converteranimations
{
	public class PrimarinaParentDad_ConverterAnimatorController : MonoBehaviour 
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
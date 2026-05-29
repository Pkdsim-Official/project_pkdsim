using project_pkdsim.ANIMATOR.Parents.Primarina.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Primarina.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Primarina.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.converteranimations
{
	public class Primarina_ConverterToAnimatorController : MonoBehaviour 
	{
		private PRSittingTo Primarinasittingto;
		
		private PRWalkingTo Primarinawalkingto;
		
		private PRIdleTo Primarinaidleto;

		public void PR_ConverterToAnimatorController()
		{
			Primarinawalkingto.PRWalkingToController();

			Primarinaidleto.PR_IdleToController();
			
			Primarinasittingto.PRSittingToController();	
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Primarina.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Primarina.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Primarina.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.converteranimations
{
	public class PrimarinaConverterAnimatorController : MonoBehaviour 
	{
		private PRSittingTo Primarinasittingto;
		
		private PRWalkingTo Primarinawalkingto;
		
		private PRIdleTo Primarinaidleto;

		public void PRConverterToAnimatorController()
		{
			Primarinawalkingto.PRWalkingToController();

			Primarinaidleto.PR_IdleToController();
			
			Primarinasittingto.PRSittingToController();	
		}
	}
}
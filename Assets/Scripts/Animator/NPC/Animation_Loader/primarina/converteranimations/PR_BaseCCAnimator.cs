using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations
{
	public class PrimarinaCoverterAnimatorController : MonoBehaviour 
	{
		private PRSittingTo Primarinasittingto;
		
		private PRWalkingTo Primarinawalkingto;
		
		private PRIdleTo Primarinaidleto;

		public void PRCoverterToAnimatorController()
		{
			Primarinawalkingto.PRWalkingToController();

			Primarinaidleto.PR_IdleToController();
			
			Primarinasittingto.PRSittingToController();	
		}
	}
}
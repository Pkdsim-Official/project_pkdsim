using Project_Pkdsim.ANIMATOR.Npcs.Primarina.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Primarina.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Primarina.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Primarina.converteranimations
{
	public class PrimarinaCoverterAnimatorController : MonoBehaviour 
	{
		private PR_SittingTo Primarinasittingto;
		
		private PR_WalkingTo Primarinawalkingto;
		
		private PR_IdleTo Primarinaidleto;

		public void PRCoverterToAnimatorController()
		{
			Primarinawalkingto.PR_WalkingToController();

			Primarinaidleto.PR_IdleToController();
			
			Primarinasittingto.PR_SittingToController();	
		}
	}
}
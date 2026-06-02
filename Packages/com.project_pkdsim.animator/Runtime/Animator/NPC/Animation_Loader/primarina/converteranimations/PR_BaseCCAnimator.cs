using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations
{
	public class Primarina_ConverterAnimatorController : MonoBehaviour 
	{
		private PR_SittingTo Primarinasittingto;
		
		private PR_WalkingTo Primarinawalkingto;
		
		private PR_IdleTo Primarinaidleto;

		public void PR_ConverterAnimatorController()
		{
			Primarinawalkingto.PR_WalkingToController();

			Primarinaidleto.PR_IdleToController();
			
			Primarinasittingto.PR_SittingToController();	
		}
	}
}
using Project_Pkdsim.ANIMATOR.Parents.Primarina.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Parents.Primarina.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Primarina.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Primarina.converteranimations
{
	public class PrimarinaConverterAnimatorController : MonoBehaviour 
	{
		private PRSittingTo Primarinasittingto;
		
		private PRWalkingTo Primarinawalkingto;
		
		private PRIdleTo Primarinaidleto;

		public void PRConverterAnimatorController()
		{
			Primarinawalkingto.PRWalkingToController();

			Primarinaidleto.PR_IdleToController();
			
			Primarinasittingto.PRSittingToController();	
		}
	}
}
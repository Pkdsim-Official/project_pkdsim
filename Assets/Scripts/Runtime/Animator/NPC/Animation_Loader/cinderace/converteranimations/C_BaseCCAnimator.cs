using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations
{
	public class CinderaceCoverterAnimatorController : MonoBehaviour 
	{
		private C_SittingTo CinderaceSittingto;
		
		private C_WalkingTo CinderaceWalkingto;
		
		private C_IdleTo CinderaceIdleto;

		public void CCoverterToAnimatorController()
		{
			CinderaceWalkingto.C_WalkingToController();

			CinderaceIdleto.C_IdleToController();
			
			CinderaceSittingto.C_SittingToController();	
		}
	}
}
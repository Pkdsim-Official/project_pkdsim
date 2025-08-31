using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations
{
	public class CinderaceCoverterAnimatorController : MonoBehaviour 
	{
		private CSittingTo CinderaceSittingto;
		
		private CWalkingTo CinderaceWalkingto;
		
		private C_IdleTo CinderaceIdleto;

		public void CCoverterToAnimatorController()
		{
			CinderaceWalkingto.CWalkingToController();

			CinderaceIdleto.C_IdleToController();
			
			CinderaceSittingto.CSittingToController();	
		}
	}
}
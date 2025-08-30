using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations
{
	public class CinderaceCoverterAnimatorController : MonoBehaviour 
	{
		private CSittingTo Cinderacesittingto;
		
		private CWalkingTo Cinderacewalkingto;
		
		private CIdleTo Cinderaceidleto;

		public void CCoverterToAnimatorController()
		{
			Cinderacewalkingto.CWalkingToController();

			Cinderaceidleto.CIdleToController();
			
			Cinderacesittingto.CSittingToController();	
		}
	}
}
using project_pkdsim.ANIMATOR.NPC.Noivern.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Noivern.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.NPC.Noivern.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Noivern.converteranimations
{
	public class NoivernCoverterAnimatorController : MonoBehaviour 
	{
		private NOISittingTo Noivernsittingto;
		
		private NOIWalkingTo Noivernwalkingto;
		
		private NOIIdleTo Noivernidleto;

		public void NOICoverterToAnimatorController()
		{
			Noivernwalkingto.NOIWalkingToController();

			Noivernidleto.NOI_IdleToController();
			
			Noivernsittingto.NOISittingToController();	
		}
	}
}
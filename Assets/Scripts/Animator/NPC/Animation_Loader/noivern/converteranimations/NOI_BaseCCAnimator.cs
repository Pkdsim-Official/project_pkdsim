using project_pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Noivern.converteranimations
{
	public class NoivernCoverterAnimatorController : MonoBehaviour 
	{
		private NOI_SittingTo Noivernsittingto;
		
		private NOI_WalkingTo Noivernwalkingto;
		
		private NOI_IdleTo Noivernidleto;

		public void NOICoverterToAnimatorController()
		{
			Noivernwalkingto.NOI_WalkingToController();

			Noivernidleto.NOI_IdleToController();
			
			Noivernsittingto.NOI_SittingToController();	
		}
	}
}
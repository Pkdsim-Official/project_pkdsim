using Project_Pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Noivern.converteranimations
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
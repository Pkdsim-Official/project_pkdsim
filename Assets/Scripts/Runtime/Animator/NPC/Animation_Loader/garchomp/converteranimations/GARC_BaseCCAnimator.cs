using Project_Pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations
{
	public class GarchompCoverterAnimatorController : MonoBehaviour 
	{
		private GARC_SittingTo GarchompSittingto;
		
		private GARC_WalkingTo GarchompWalkingto;
		
		private GARC_IdleTo GarchompIdleto;

		public void GARCCoverterToAnimatorController()
		{
			GarchompWalkingto.GARC_WalkingToController();

			GarchompIdleto.GARC_IdleToController();
			
			GarchompSittingto.GARC_SittingToController();	
		}
	}
}
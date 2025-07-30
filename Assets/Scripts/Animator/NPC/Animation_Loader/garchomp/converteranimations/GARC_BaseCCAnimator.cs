using project_pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations
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
using project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations
{
	public class GardevoirCoverterAnimatorController : MonoBehaviour 
	{
		private GARD_SittingTo GardevoirSittingto;
		
		private GARD_WalkingTo GardevoirWalkingto;
		
		private GARD_IdleTo GardevoirIdleto;

		public void GARD_CoverterToAnimatorController()
		{
			GardevoirWalkingto.GARD_WalkingToController();

			GardevoirIdleto.GARD_IdleToController();
			
			GardevoirSittingto.GARD_SittingToController();	
		}
	}
}
using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations
{
	public class GardevoirCoverterAnimatorController : MonoBehaviour 
	{
		private GARDSittingTo Gardevoirsittingto;
		
		private GARDWalkingTo Gardevoirwalkingto;
		
		private GARDIdleTo Gardevoiridleto;

		public void GARDCoverterToAnimatorController()
		{
			Gardevoirwalkingto.GARDWalkingToController();

			Gardevoiridleto.GARDIdleToController();
			
			Gardevoirsittingto.GARDSittingToController();	
		}
	}
}
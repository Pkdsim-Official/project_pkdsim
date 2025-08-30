using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Dragapult.converteranimations
{
	public class DragapultCoverterAnimatorController : MonoBehaviour 
	{
		private DRSittingTo Dragapultsittingto;
		
		private DRWalkingTo Dragapultwalkingto;
		
		private DRIdleTo Dragapultidleto;

		public void DRCoverterToAnimatorController()
		{
			Dragapultwalkingto.DRWalkingToController();

			Dragapultidleto.DRIdleToController();
			
			Dragapultsittingto.DRSittingToController();	
		}
	}
}
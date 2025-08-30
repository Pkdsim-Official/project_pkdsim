using project_pkdsim.Models.ANIMATOR.NPC.Vespiquen.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Vespiquen.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Vespiquen.converteranimations
{
	public class VespiquenCoverterAnimatorController : MonoBehaviour 
	{
		private VESittingTo Vespiquensittingto;
		
		private VEWalkingTo Vespiquenwalkingto;
		
		private VEIdleTo Vespiquenidleto;

		public void VECoverterToAnimatorController()
		{
			Vespiquenwalkingto.VEWalkingToController();

			Vespiquenidleto.VEIdleToController();
			
			Vespiquensittingto.VESittingToController();	
		}
	}
}
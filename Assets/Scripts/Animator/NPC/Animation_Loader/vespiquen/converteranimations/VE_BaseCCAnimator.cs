using project_pkdsim.ANIMATOR.NPC.Vespiquen.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.NPC.Vespiquen.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Vespiquen.converteranimations
{
	public class VespiquenCoverterAnimatorController : MonoBehaviour 
	{
		private VE_SittingTo Vespiquensittingto;
		
		private VE_WalkingTo Vespiquenwalkingto;
		
		private VE_IdleTo Vespiquenidleto;

		public void VECoverterToAnimatorController()
		{
			Vespiquenwalkingto.VE_WalkingToController();

			Vespiquenidleto.VE_IdleToController();
			
			Vespiquensittingto.VE_SittingToController();	
		}
	}
}
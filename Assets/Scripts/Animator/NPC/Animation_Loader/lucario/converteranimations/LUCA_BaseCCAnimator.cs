using project_pkdsim.Models.ANIMATOR.NPC.Lucario.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Lucario.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Lucario.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Lucario.converteranimations
{
	public class LucarioCoverterAnimatorController : MonoBehaviour 
	{
		private LUCASittingTo Lucariosittingto;
		
		private LUCAWalkingTo Lucariowalkingto;
		
		private LUCAIdleTo Lucarioidleto;

		public void LUCACoverterToAnimatorController()
		{
			Lucariowalkingto.LUCAWalkingToController();

			Lucarioidleto.LUCAIdleToController();
			
			Lucariosittingto.LUCASittingToController();	
		}
	}
}
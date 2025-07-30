using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations
{
	public class LucarioCoverterAnimatorController : MonoBehaviour 
	{
		private LUCA_SittingTo Lucariosittingto;
		
		private LUCA_WalkingTo Lucariowalkingto;
		
		private LUCA_IdleTo Lucarioidleto;

		public void LUCACoverterToAnimatorController()
		{
			Lucariowalkingto.LUCA_WalkingToController();

			Lucarioidleto.LUCA_IdleToController();
			
			Lucariosittingto.LUCA_SittingToController();	
		}
	}
}
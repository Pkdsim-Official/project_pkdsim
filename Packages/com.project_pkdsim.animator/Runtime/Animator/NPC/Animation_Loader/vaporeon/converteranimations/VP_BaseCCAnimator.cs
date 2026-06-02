using project_pkdsim.ANIMATOR.NPC.Vaporeon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.NPC.Vaporeon.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Vaporeon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Vaporeon.converteranimations
{
	public class Vaporeon_ConverterAnimatorController : MonoBehaviour 
	{
		private VP_SittingTo VaporeonSittingto;
		
		private VP_WalkingTo VaporeonWalkingto;
		
		private VP_IdleTo VaporeonIdleto;

		private void VP_Base_IdleAnimatorController()
		{
			VaporeonWalkingto.VP_WalkingToController();

			VaporeonIdleto.VP_IdleToController();
			
			VaporeonSittingto.VP_SittingToController();	
		}
	}
}
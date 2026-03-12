using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations.WalkingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations.IdleTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations
{
	public class Vaporeon_CoverterAnimatorController : MonoBehaviour 
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
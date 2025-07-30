using project_pkdsim.ANIMATOR.Npcs.Umbreon.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Npcs.Umbreon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Npcs.Umbreon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Umbreon.converteranimations
{
	public class Umbreon_ConverterAnimatorController : MonoBehaviour 
	{
		private UM_SittingTo UmbreonSittingto;
		
		private UM_WalkingTo UmbreonWalkingto;
		
		private UM_IdleTo UmbreonIdleto;

		private void UM_Base_IdleAnimatorController()
		{
			UmbreonWalkingto.UM_WalkingToController();

			UmbreonIdleto.UM_IdleToController();
			
			UmbreonSittingto.UM_SittingToController();	
		}
	}
}
using Project_Pkdsim.ANIMATOR.Npcs.Umbreon.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Umbreon.converteranimations.WalkingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Umbreon.converteranimations.IdleTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Umbreon.converteranimations
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
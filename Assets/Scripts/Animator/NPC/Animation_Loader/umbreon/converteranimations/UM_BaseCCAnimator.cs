using project_pkdsim.ANIMATOR.NPC.Umbreon.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.NPC.Umbreon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.NPC.Umbreon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Umbreon.converteranimations
{
	public class Umbreon_AnimatorBaseConverterController : MonoBehaviour 
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
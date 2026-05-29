using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations
{
	public class Lucario_ConverterToAnimatorController : MonoBehaviour 
	{
		private LUCA_SittingTo Lucariosittingto;
		
		private LUCA_WalkingTo Lucariowalkingto;
		
		private LUCA_IdleTo Lucarioidleto;

		public void LUCA_ConverterToAnimatorController()
		{
			Lucariowalkingto.LUCA_WalkingToController();

			Lucarioidleto.LUCA_IdleToController();
			
			Lucariosittingto.LUCA_SittingToController();	
		}
	}
}
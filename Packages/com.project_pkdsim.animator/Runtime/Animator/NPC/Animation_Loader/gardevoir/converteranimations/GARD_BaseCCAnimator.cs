using project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations
{
	public class Gardevoir_ConverterToAnimatorController : MonoBehaviour 
	{
		private GARD_SittingTo GardevoirSittingto;
		
		private GARD_WalkingTo GardevoirWalkingto;
		
		private GARD_IdleTo GardevoirIdleto;

		public void GARD_ConverterToAnimatorController()
		{
			GardevoirWalkingto.GARD_WalkingToController();

			GardevoirIdleto.GARD_IdleToController();
			
			GardevoirSittingto.GARD_SittingToController();	
		}
	}
}
using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations
{
	public class AbsolCoverterAnimatorController : MonoBehaviour 
	{
		private ABSittingTo Absolsittingto;
		
		private ABWalkingTo Absolwalkingto;
		
		private ABIdleTo Absolidleto;

		public void ABCoverterToAnimatorController()
		{
			Absolwalkingto.ABWalkingToController();

			Absolidleto.ABIdleToController();
			
			Absolsittingto.ABSittingToController();	
		}
	}
}
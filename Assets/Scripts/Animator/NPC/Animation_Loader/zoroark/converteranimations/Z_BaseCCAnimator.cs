using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations
{
	public class ZoroarkCoverterAnimatorController : MonoBehaviour 
	{
		private ZSittingTo Zoroarksittingto;
		
		private ZWalkingTo Zoroarkwalkingto;
		
		private ZIdleTo Zoroarkidleto;

		public void ZCoverterToAnimatorController()
		{
			Zoroarkwalkingto.ZWalkingToController();

			Zoroarkidleto.Z_IdleToController();
			
			Zoroarksittingto.ZSittingToController();	
		}
	}
}
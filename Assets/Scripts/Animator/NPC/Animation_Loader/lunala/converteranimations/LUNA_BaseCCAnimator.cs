using project_pkdsim.Models.ANIMATOR.NPC.Lunala.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Lunala.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Lunala.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Lunala.converteranimations
{
	public class LunalaCoverterAnimatorController : MonoBehaviour 
	{
		private LUNASittingTo Lunalasittingto;
		
		private LUNAWalkingTo Lunalawalkingto;
		
		private LUNAIdleTo Lunalaidleto;

		public void LUNACoverterToAnimatorController()
		{
			Lunalawalkingto.LUNAWalkingToController();

			Lunalaidleto.LUNA_IdleToController();
			
			Lunalasittingto.LUNASittingToController();	
		}
	}
}
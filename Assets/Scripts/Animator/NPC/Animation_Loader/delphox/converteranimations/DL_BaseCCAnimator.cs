using project_pkdsim.Models.ANIMATOR.NPC.Delphox.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Delphox.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Delphox.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Delphox.converteranimations
{
	public class DelphoxCoverterAnimatorController : MonoBehaviour 
	{
		private DLSittingTo Delphoxsittingto;
		
		private DLWalkingTo Delphoxwalkingto;
		
		private DLIdleTo Delphoxidleto;

		public void DLCoverterToAnimatorController()
		{
			Delphoxwalkingto.DLWalkingToController();

			Delphoxidleto.DLIdleToController();
			
			Delphoxsittingto.DLSittingToController();	
		}
	}
}
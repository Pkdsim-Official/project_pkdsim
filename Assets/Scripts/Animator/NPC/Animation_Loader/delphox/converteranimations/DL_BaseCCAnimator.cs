using project_pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Delphox.converteranimations
{
	public class DelphoxCoverterAnimatorController : MonoBehaviour 
	{
		private DL_SittingTo DelphoxSittingto;
		
		private DL_WalkingTo DelphoxWalkingto;
		
		private DL_IdleTo DelphoxIdleto;

		public void DLCoverterToAnimatorController()
		{
			DelphoxWalkingto.DL_WalkingToController();

			DelphoxIdleto.DL_IdleToController();
			
			DelphoxSittingto.DL_SittingToController();	
		}
	}
}
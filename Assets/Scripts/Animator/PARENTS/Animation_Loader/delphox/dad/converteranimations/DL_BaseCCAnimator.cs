using project_pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations
{
	public class DelphoxConverterAnimatorController : MonoBehaviour 
	{
		private DLSittingTo DelphoxSittingto;
		
		private DLWalkingTo DelphoxWalkingto;
		
		private DL_IdleTo DelphoxIdleto;

		public void DLConverterAnimatorController()
		{
			DelphoxWalkingto.DLWalkingToController();

			DelphoxIdleto.DL_IdleToController();
			
			DelphoxSittingto.DLSittingToController();	
		}
	}
}
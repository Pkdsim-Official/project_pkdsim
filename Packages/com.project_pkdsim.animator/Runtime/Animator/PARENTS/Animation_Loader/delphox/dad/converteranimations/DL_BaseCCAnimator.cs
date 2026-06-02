using project_pkdsim.ANIMATOR.Parents.Delphox.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Delphox.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Delphox.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.converteranimations
{
	public class DelphoxParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private DLSittingTo DelphoxSittingto;
		
		private DLWalkingTo DelphoxWalkingto;
		
		private DL_IdleTo DelphoxIdleto;

		public void DL_ConverterAnimatorController()
		{
			DelphoxWalkingto.DLWalkingToController();

			DelphoxIdleto.DL_IdleToController();
			
			DelphoxSittingto.DLSittingToController();	
		}
	}
}
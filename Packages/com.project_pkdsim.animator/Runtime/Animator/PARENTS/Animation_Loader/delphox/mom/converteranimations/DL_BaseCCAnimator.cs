using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations
{
	public class DelphoxParentMom_ConverterToAnimatorController : MonoBehaviour 
	{
		private DLSittingTo DelphoxSittingto;
		
		private DLWalkingTo DelphoxWalkingto;
		
		private DL_IdleTo DelphoxIdleto;

		public void DL_ConverterToAnimatorController()
		{
			DelphoxWalkingto.DLWalkingToController();

			DelphoxIdleto.DL_IdleToController();
			
			DelphoxSittingto.DLSittingToController();	
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations
{
	public class DelphoxParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private DLParentMom_SittingTo DelphoxParentMomSittingto;
		
		private DLParentMom_WalkingTo DelphoxParentMomWalkingto;
		
		private DLParentMom_IdleTo DelphoxParentMomIdleto;

		public void DLParentMom_ConverterAnimatorController()
		{
			DelphoxParentMomWalkingto.DLParentMom_WalkingToController();

			DelphoxParentMomIdleto.DLParentMom_IdleToController();
			
			DelphoxParentMomSittingto.DLParentMom_SittingToController();	
		}
	}
}
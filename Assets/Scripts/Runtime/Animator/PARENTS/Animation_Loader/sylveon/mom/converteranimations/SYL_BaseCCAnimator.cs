using Project_Pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations
{
	public class SylveonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private SYLParentMom_SittingTo SylveonParentMomSittingto;
		
		private SYLParentMom_WalkingTo SylveonParentMomWalkingto;
		
		private SYLParentMom_IdleTo SylveonParentMomIdleto;

		public void SYLParentMom_ConverterAnimatorController()
		{
			SylveonParentMomWalkingto.SYLParentMom_WalkingToController();

			SylveonParentMomIdleto.SYLParentMom_IdleToController();
			
			SylveonParentMomSittingto.SYLParentMom_SittingToController();	
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations
{
	public class JolteonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private JTParentMom_SittingTo JolteonParentMomSittingto;
		
		private JTParentMom_WalkingTo JolteonParentMomWalkingto;
		
		private JTParentMom_IdleTo JolteonParentMomIdleto;

		public void JTParentMom_ConverterAnimatorController()
		{
			JolteonParentMomWalkingto.JTParentMom_WalkingToController();

			JolteonParentMomIdleto.JTParentMom_IdleToController();
			
			JolteonParentMomSittingto.JTParentMom_SittingToController();	
		}
	}
}
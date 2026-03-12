using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations
{
	public class AbsolParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private ABParentMom_SittingTo AbsolParentMomSittingto;
		
		private ABParentMom_WalkingTo AbsolParentMomWalkingto;
		
		private ABParentMom_IdleTo AbsolParentMomIdleto;

		public void ABParentMom_ConverterAnimatorController()
		{
			AbsolParentMomWalkingto.ABParentMom_WalkingToController();

			AbsolParentMomIdleto.ABParentMom_IdleToController();
			
			AbsolParentMomSittingto.ABParentMom_SittingToController();	
		}
	}
}
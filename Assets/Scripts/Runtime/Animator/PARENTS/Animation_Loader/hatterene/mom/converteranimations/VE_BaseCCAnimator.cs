using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations
{
	public class HattereneParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private HATParentMom_SittingTo HattereneParentMomSittingto;
		
		private HATParentMom_WalkingTo HattereneParentMomWalkingto;
		
		private HATParentMom_IdleTo HattereneParentMomIdleto;

		public void HATParentMom_ConverterAnimatorController()
		{
			HattereneParentMomWalkingto.HATParentMom_WalkingToController();

			HattereneParentMomIdleto.HATParentMom_IdleToController();
			
			HattereneParentMomSittingto.HATParentMom_SittingToController();	
		}
	}
}
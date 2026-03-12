using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ID.ItemsScripts.Gifts.Necklaces.Electric.Spark_necklace
{
    public class Spark_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Spark_Necklace_ID()
        {
            // 77777277755 = Spark
            // 7777 = s
            // 7 = p
            // 2 = a
            // 777 = r
            // 55 = k
            CustomUUID = "77777277755-663322255555222233";
            Name = "Spark Necklace";
            Category = "Necklace";
        }
    }
}
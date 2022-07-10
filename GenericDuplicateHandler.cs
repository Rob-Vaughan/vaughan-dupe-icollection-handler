using System.Collections;

namespace Vaughan_Generic_Duplicate_Handler
{
    public class GenericDuplicateHandler
    {
        /// <summary>
        /// RemoveDuplicates() method returns an ICollection of distinct objects from an ICollection.
        /// </summary>
        /// 
        /// <param name="collection">
        /// an ICollection with possible duplicate values
        /// </param>
        /// 
        /// <returns>
        /// an ICollection with duplicate values removed
        /// </returns>


        public static ICollection removeDuplicates<T>(ICollection collection) 
        {
            var retCol = new List<T>();
            foreach (var item in collection)
                if (!retCol.Contains((T)item))
                    retCol.Add((T)item);
            return retCol;
        }
    }
}

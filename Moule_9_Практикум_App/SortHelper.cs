namespace Moule_9_Практикум_App
{

    public class SortHelper
    {
        public delegate void SortEventHandler(List<string> surnames, bool ascending);
        public event SortEventHandler? SortEvent;

        /// <summary>
        /// Метод для сортировки массива.
        /// </summary>
        /// <param name="surnames">Принимает список фамилий.</param>
        /// <param name="ascending">Принцип сортировки</param>
        public void TriggerSort(List<string> surnames, bool ascending)
        {
            SortEvent?.Invoke(surnames, ascending);
        }
    }
}

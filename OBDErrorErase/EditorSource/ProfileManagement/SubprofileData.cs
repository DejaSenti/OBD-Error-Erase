using OBDErrorErase.EditorSource.Maps;
using System.Collections;
using System.ComponentModel;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class SubprofileData : IListSource
    {
        private uint mapLength;
        private List<BaseMap> maps = new();

        public bool ContainsListCollection => throw new NotImplementedException();

        public IList GetList()
        {
            BindingList<BaseMap> list = new BindingList<BaseMap>(maps);

            return list;
        }
    }
}
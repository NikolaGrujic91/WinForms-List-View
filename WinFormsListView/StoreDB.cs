using System.Data;
using System.Windows.Forms;

namespace WinFormsListView
{
    internal class StoreDB
    {
        public static DataTable GetProducts()
        {
            var dsStore = new DataSet();
            dsStore.ReadXmlSchema(Application.StartupPath + "\\store.xsd");
            dsStore.ReadXml(Application.StartupPath + "\\store.xml");
            return dsStore.Tables["Products"];
        }
    }
}

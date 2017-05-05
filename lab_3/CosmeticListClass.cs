using System.Text;
using System.Threading.Tasks;
using lab_3.Factories;
using System.IO;
using System.ComponentModel;
using lab_3.Classes;

namespace lab_3
{
    public class CosmeticListClass
    {
       // private BindingList<CosmeticListClass> cosmeticList = new BindingList<CosmeticListClass>();
        public BindingList<CosmeticProduct> CosmeticList { get; set; }

        public CosmeticListClass()
        {
            CosmeticList = new BindingList<CosmeticProduct>();
        }

        private char separator = '|';

        public void SerializeItemsInList(string fileName)
        {

        }

        public void DeserializeItemsInList(string fileName, AllProductsFactory formEditorFactory)
        {

        }

    }
}

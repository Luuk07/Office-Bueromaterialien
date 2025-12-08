using Office_Büromaterialienbestellung.Classes.Records;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Büromaterialienbestellung.Classes.Services
{
    public class CclSvcMain
    {
        private CclSvcDataStorage _svcDB = new CclSvcDataStorage();
        public ObservableCollection<CclRecProduct> Products { get; set; }

        public CclSvcMain()
        {
            //Holt die Daten aus der DB und speichert sie in der ObservableCollection
            Products = new ObservableCollection<CclRecProduct>(_svcDB.getDataFromDB());

            // Bei Änderung wird SaveProduct aufgerufen
            Products.CollectionChanged += (s, e) => SaveProduct();

        }


        public void SaveProduct()
        {
            _svcDB.putDataToDB(Products.ToList());
        }

        public void ReloadProduct()
        {

            var fresh = _svcDB.getDataFromDB();


            Products.Clear();


            foreach (var item in fresh)
                Products.Add(item);

        }

        public void SetAllOrdered()
        {
            foreach (var item in Products)
            {
                item.IsOrdered = true;
                item.IsPreOrdered = false;
                item.IsReceived = false;
            }
            SaveProduct();
        }
        public void OnIsOrdered(CclRecProduct product)
        {
            product.IsOrdered = true;
            product.IsPreOrdered = false;
            product.IsReceived = false;
            product.Deleted = false;
            _svcDB.putDataToDB(Products.ToList());

        }
    }
}

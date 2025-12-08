using CDS.Classes;
using CDS.Enumerations;
using Office_Büromaterialienbestellung.Classes.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Office_Büromaterialienbestellung.Classes.Services
{
    public class CclSvcDataStorage
    {
        private CclCDSDatabase clCDSDatabase;
        private CclCDSTable<CclRecProduct> clProductList;
        public CclSvcDataStorage()
        {
            clCDSDatabase = new CclCDSDatabase(CDSStorageType.MariaDB);
            clProductList = new CclCDSTable<CclRecProduct>(clCDSDatabase.BaseDB.CreateDataAccess());
        }

        public CclCDSTable<CclRecProduct> getDataFromDB()
        {
            // Daten laden
            clProductList.LoadData();
            return clProductList;
        }

        public void putDataToDB(List<CclRecProduct> _liRecProducts)
        {
            
            try
            {
                clProductList.Clear();
                clProductList.AddRange(_liRecProducts);
                clProductList.SaveData();
            }

            catch (Exception excError)
            {
                MessageBox.Show(excError.Message);
            }
        }
    }
}

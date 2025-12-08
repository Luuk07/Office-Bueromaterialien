using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDS.Classes.Attributes;
using CDS.Classes.Data;

namespace Office_Büromaterialienbestellung.Classes.Records
{
    //Record for Products

    [CDSTable("product", "DB", "")]
    public class CclRecProduct : CclCDSRecBase
    {
        #region Constants
        ///**************************************************
        /// Constants
        private const string I_strCryptoKey = "e950tu dfb-<y.dx epotz sölrdjt a94et dflkgd";

        #endregion Constants

        #region Instance variables
        ///**************************************************
        /// Instance variables
        /// 
        private int I_intProductID;
        private string I_strProductName;
        private int I_intAmount;
        private string I_strUserName;
        private bool I_boolIsPreOrdered;
        private bool I_boolIsOrdered;
        private bool I_boolIsReceived;
        //private bool I_boolIsDeleted;

        //private string I_strPassword;

        #endregion Instance variables

        #region Properties
        ///**************************************************
        /// Properties
        [CDSField(0, 0, true, false, false, true)] public int OrderID { get; set; }

        public int ProductID { get { return I_intProductID; } set { SetValue(ref I_intProductID, value); } }

        public string ProductName { get { return I_strProductName; } set { SetValue(ref I_strProductName, value); } }
        public int Amount { get { return I_intAmount; } set { SetValue(ref I_intAmount, value); } }
        public string UserName { get { return I_strUserName; } set { SetValue(ref I_strUserName, value); } }

        public bool IsPreOrdered { get { return I_boolIsPreOrdered; } set { SetValue(ref I_boolIsPreOrdered, value); } }

        public bool IsOrdered { get { return I_boolIsOrdered; } set { SetValue(ref I_boolIsOrdered, value); } }

        public bool IsReceived { get { return I_boolIsReceived; } set { SetValue(ref I_boolIsReceived, value); } }

       // public bool IsDeleted { get { return I_boolIsDeleted; } set { SetValue(ref I_boolIsDeleted, value); } }





        #endregion Properties

        #region Initialization
        ///**************************************************
        /// <summary>
        /// Standard constructor. Initializes the instance.
        /// </summary>
        public CclRecProduct() : this(string.Empty,int.MinValue, int.MinValue, string.Empty, true, false, false) { }

        ///**************************************************
        /// <summary>
        /// Extended constructor. Initializes the instance.
        /// </summary>
        /// <param name="_strUser">Value for 'ArchivePath'.</param>
        /// <param name="_strDomain">Value for 'ErrorPath'.</param>
        /// <param name="_strPassword">Value for 'ErrorMailSender'.</param>
        /// <param name="_iTimeOut">Value for 'ErrorMailReceiver'.</param>
        public CclRecProduct(string _strProductName, int I_intProductID, int _intAmount, string _strUserName, bool _boolIsPreOrdered, bool _boolIsOrdered, bool _boolIsReceived)
        {
            ProductName = _strProductName;
            ProductID = I_intProductID;
            Amount = _intAmount;
            //Password = _strPassword;
            UserName = _strUserName;
            IsPreOrdered = _boolIsPreOrdered;
            IsOrdered = _boolIsOrdered;
            IsReceived = _boolIsReceived;
           //IsDeleted = _boolIsDeleted;
        }

        #endregion Initialization
    }
}

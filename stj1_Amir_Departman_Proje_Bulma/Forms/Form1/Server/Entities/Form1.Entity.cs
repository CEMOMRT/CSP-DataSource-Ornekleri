//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.1.32
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bimser.CSP.FormControls.Entities;
using Bimser.Framework.Attributes.Database;
using Bimser.Framework.Domain;
using Bimser.Framework.Domain.Entities;

namespace stj1_Amir_Departman_Proje_Bulma.Entities {
    
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1Entity : FormEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1Entity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<bool>> _RdDurum;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _NbSayi;
        
        private E_stj1_Amir_Departman_Proje_Bulma_Form1VREntity _VersionEntity;
        
        private RDEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1RDEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1RDMLEntity> _RD;
        
        private RDCEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1RDCEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1RDCMLEntity> _RDC;
        
        private MLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1MLEntity> _ML;
        
        private SLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1SLMLEntity> _SL;
        
        private GridEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1Entity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1MLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLMLEntity> _E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1;
        
        public E_stj1_Amir_Departman_Proje_Bulma_Form1Entity() {
            this.ML = new MLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1MLEntity>();
            this.VersionEntity = new E_stj1_Amir_Departman_Proje_Bulma_Form1VREntity();
            this.RD = new RDEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1RDEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1RDMLEntity>();
            this.RDC = new RDCEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1RDCEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1RDCMLEntity>();
            this.E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1 = new GridEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1Entity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1MLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLMLEntity>();
            this.E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1.MLEntityEnabled = false;
            this.E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1.SLEntityEnabled = false;
            this.SL = new SLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1SLMLEntity>();
        }
        
        [ColumnOptionsAttribute(Name="RdDurum", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<bool>> RdDurum {
            get {
                return this._RdDurum;
            }
            set {
                this._RdDurum = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="NbSayi", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> NbSayi {
            get {
                return this._NbSayi;
            }
            set {
                this._NbSayi = value;
            }
        }
        
        public E_stj1_Amir_Departman_Proje_Bulma_Form1VREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1RDEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1RDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1RDCEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1RDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public MLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1MLEntity> ML {
            get {
                return this._ML;
            }
            set {
                this._ML = value;
            }
        }
        
        public SLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1SLMLEntity> SL {
            get {
                return this._SL;
            }
            set {
                this._SL = value;
            }
        }
        
        public GridEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1Entity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1MLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLMLEntity> E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1 {
            get {
                return this._E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1;
            }
            set {
                this._E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1 = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1ML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1MLEntity : MLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1MLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _TxtAciklama;
        
        [ColumnOptionsAttribute(Name="TxtAciklama", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> TxtAciklama {
            get {
                return this._TxtAciklama;
            }
            set {
                this._TxtAciklama = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1SL")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1SLEntity : SLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1SLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1SLML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1SLMLEntity : SLMLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1SLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1Entity : GridEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1Entity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1MLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLMLEntity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _RELATIONDOCUMENTID;
        
        public E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1Entity() {
        }
        
        [ColumnOptionsAttribute(Name="RELATIONDOCUMENTID", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> RELATIONDOCUMENTID {
            get {
                return this._RELATIONDOCUMENTID;
            }
            set {
                this._RELATIONDOCUMENTID = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1ML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1MLEntity : GridMLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1MLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SL")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLEntity : GridSLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLMLEntity : GridSLMLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1_DataGrid1SLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1VR")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1VREntity : VersionEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1VREntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1RDC")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1RDCEntity : RDCEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1RDCEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1RDCMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1RDCML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1RDCMLEntity : RDCMLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1RDCMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1RD")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1RDEntity : RDEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1RDEntity, E_stj1_Amir_Departman_Proje_Bulma_Form1RDMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form1RDML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form1RDMLEntity : RDMLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form1RDMLEntity> {
    }
}





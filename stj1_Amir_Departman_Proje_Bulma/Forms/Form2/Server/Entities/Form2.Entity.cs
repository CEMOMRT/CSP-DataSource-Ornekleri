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
    
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2Entity : FormEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2Entity> {
        
        private E_stj1_Amir_Departman_Proje_Bulma_Form2VREntity _VersionEntity;
        
        private RDEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2RDEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2RDMLEntity> _RD;
        
        private RDCEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2RDCEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2RDCMLEntity> _RDC;
        
        private MLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2MLEntity> _ML;
        
        private SLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2SLMLEntity> _SL;
        
        private GridEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1Entity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1MLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLMLEntity> _E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1;
        
        public E_stj1_Amir_Departman_Proje_Bulma_Form2Entity() {
            this.ML = new MLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2MLEntity>();
            this.VersionEntity = new E_stj1_Amir_Departman_Proje_Bulma_Form2VREntity();
            this.RD = new RDEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2RDEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2RDMLEntity>();
            this.RDC = new RDCEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2RDCEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2RDCMLEntity>();
            this.E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1 = new GridEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1Entity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1MLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLMLEntity>();
            this.E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1.MLEntityEnabled = true;
            this.E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1.SLEntityEnabled = true;
            this.SL = new SLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2SLMLEntity>();
        }
        
        public E_stj1_Amir_Departman_Proje_Bulma_Form2VREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2RDEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2RDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2RDCEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2RDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public MLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2MLEntity> ML {
            get {
                return this._ML;
            }
            set {
                this._ML = value;
            }
        }
        
        public SLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2SLMLEntity> SL {
            get {
                return this._SL;
            }
            set {
                this._SL = value;
            }
        }
        
        public GridEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1Entity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1MLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLMLEntity> E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1 {
            get {
                return this._E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1;
            }
            set {
                this._E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1 = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2ML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2MLEntity : MLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2MLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _TxtDetay;
        
        [ColumnOptionsAttribute(Name="TxtDetay", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> TxtDetay {
            get {
                return this._TxtDetay;
            }
            set {
                this._TxtDetay = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2SL")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2SLEntity : SLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2SLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2SLML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2SLMLEntity : SLMLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2SLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1Entity : GridEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1Entity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1MLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLMLEntity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _ModalDgId;
        
        public E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1Entity() {
            this.SL = new GridSLEntityCollection<E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLMLEntity>();
        }
        
        [ColumnOptionsAttribute(Name="ModalDgId", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> ModalDgId {
            get {
                return this._ModalDgId;
            }
            set {
                this._ModalDgId = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1ML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1MLEntity : GridMLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1MLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _ModalDgAciklama;
        
        [ColumnOptionsAttribute(Name="ModalDgAciklama", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> ModalDgAciklama {
            get {
                return this._ModalDgAciklama;
            }
            set {
                this._ModalDgAciklama = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SL")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLEntity : GridSLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLMLEntity : GridSLMLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2_ModalDataGrid1SLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2VR")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2VREntity : VersionEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2VREntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2RDC")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2RDCEntity : RDCEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2RDCEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2RDCMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2RDCML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2RDCMLEntity : RDCMLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2RDCMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2RD")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2RDEntity : RDEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2RDEntity, E_stj1_Amir_Departman_Proje_Bulma_Form2RDMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_Amir_Departman_Proje_Bulma_Form2RDML")]
    public class E_stj1_Amir_Departman_Proje_Bulma_Form2RDMLEntity : RDMLEntity<E_stj1_Amir_Departman_Proje_Bulma_Form2RDMLEntity> {
    }
}





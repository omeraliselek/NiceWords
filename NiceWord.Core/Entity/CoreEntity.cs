using NiceWord.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceWord.Core.Entity
{
    public class CoreEntity:IEntity
    {
        public CoreEntity()
        {
            this.Status = Status.Active;
            this.CreatedDate = DateTime.Now;
            this.CreatedUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.CreatedComputerName = Environment.MachineName;
            this.CreatedIP = "123";
        }

        public Guid ID { get; set; } //Stardart ID
        public Guid MasterID { get; set; } //Üst Düzey Yönetici için ID
        public DateTime? CreatedDate { get; set; } //İşlemin Oluşturulma Tarihi
        public string CreatedComputerName { get; set; } // işlemi Yapan Bilgisayarın Adı
        public string CreatedUserName { get; set; } // işlemi yapan Üyenin Adı
        public Guid? CreatedBy { get; set; }  // Kimin Tarafından Oluşturuldu
        public string CreatedIP { get; set; } // işlemi yapan kişinin İP Adresi -- 
        // Matematiksel İşlem yapılmayacağı için CretedIP String olarak tanımlandı

        public DateTime? ModifiedDate { get; set; } // Düzenlenme Taihi
        public string ModifiedComputerName { get; set; } //Düzenlemeyi yapan bilgisayayarın Adı
        public string ModifiedIP { get; set; } //Düzenlemeyi yapan bilgisayayarın İP Adresi
        public string ModifiedUserName { get; set; } //Düzenlemeyi yapan Üyenin Adı
        public Guid? ModifiedBy { get; set; } // Kimin Tarafından Düzenleme yapıldı

        public Status Status { get; set; } // Statusu
    }
}// NOT:  "?" boş Geçilebilir ifade etmektedir.

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfDecoration.Properties
{
    using System;
    using System.Collections.Generic;
    
    public partial class продукция
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public продукция()
        {
            this.состав_заказа_клиента = new HashSet<состав_заказа_клиента>();
        }
    
        public int id_продукции { get; set; }
        public string артикул { get; set; }
        public string наименование { get; set; }
        public string еденица_измерения { get; set; }
        public Nullable<decimal> стоимость { get; set; }
        public Nullable<int> размер_максимально_возможной_скидки { get; set; }
        public string производитель { get; set; }
        public string поставщик { get; set; }
        public Nullable<int> id_категория_товара { get; set; }
        public Nullable<int> действующая_скидка { get; set; }
        public Nullable<int> количество_на_складе { get; set; }
        public string описание { get; set; }
        public string изображение { get; set; }
    
        public virtual категория_товара категория_товара { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<состав_заказа_клиента> состав_заказа_клиента { get; set; }
    }
}

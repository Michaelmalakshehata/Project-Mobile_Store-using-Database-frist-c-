//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace main
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class accessierdetaile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public accessierdetaile()
        {
            this.Bills = new HashSet<Bill>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string type { get; set; }
        public int quantity { get; set; }
        public double warranty { get; set; }
        public string date { get; set; }
    
        public virtual accessierimage accessierimage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        accessContext context=new accessContext();
        //add new item and if exist increase with new quantity
        #region add function
        public bool Add(string nms, double prices, string types, int quantitys, double warrantys, string dates)
        {
            var datashow = context.accessierdetailes.Where(n => n.name == nms).Select(n => n.name).FirstOrDefault();
            if (datashow == null)
            {
                accessierdetaile dataobject = new accessierdetaile() { name = nms, price = prices, type = types, quantity = quantitys, warranty = warrantys, date = dates };
                context.accessierdetailes.Add(dataobject);
                context.SaveChanges();
                return true;
            }
            else
            {
                int q = context.accessierdetailes.Where(n => n.name == nms).Select(n => n.quantity).FirstOrDefault();
                int newquantity = q + quantitys;
                int indexrow = context.accessierdetailes.Where(m => m.name == nms).Select(m => m.id).FirstOrDefault();
                accessierdetaile dataobject = new accessierdetaile() { id = indexrow, name = nms, price = prices, type = types, quantity = newquantity, warranty = warrantys, date = dates };
                context.Entry(dataobject).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return false;
            }

        }
        #endregion

        ///function to update searched item
        #region update function
        public bool update(string nms, double prices, string types, int quantitys, double warrantys, string dates)
        {
            try
            {
                int indexrow = context.accessierdetailes.Where(m => m.name == nms).Select(m => m.id).FirstOrDefault();
                accessierdetaile dataobject = new accessierdetaile() { id = indexrow, name = nms, price = prices, type = types, quantity = quantitys, warranty = warrantys, date = dates };
                context.Entry(dataobject).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

    }
}
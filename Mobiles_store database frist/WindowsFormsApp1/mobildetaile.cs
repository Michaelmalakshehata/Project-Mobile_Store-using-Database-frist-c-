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

    public partial class mobildetaile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mobildetaile()
        {
            this.Bills = new HashSet<Bill>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public double screen { get; set; }
        public int storage { get; set; }
        public int ram { get; set; }
        public int battery { get; set; }
        public int front_camera { get; set; }
        public int back_camera { get; set; }
        public string processor { get; set; }
        public string android { get; set; }
        public string network { get; set; }
        public int quantity { get; set; }
        public double warranty { get; set; }
        public string date { get; set; }
    
        public virtual mobile_images mobile_images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        accessContext context = new accessContext();
        //add new item and if exist increase with new quantity
        #region add function
        public bool Addnotitmexist(string nms, double prices, double screens, int storages, int rams, int batterys, int front_cameras, int back_cameras, string processors, string androids, string networks, int quantitys, double warrantys, string dates)
        {
            var datashow = context.mobildetailes.Where(n => n.name == nms).Select(n => n.name).FirstOrDefault();
            if (datashow == null)
            {
                mobildetaile dataobject = new mobildetaile() { name = nms, price = prices, screen = screens, storage = storages, ram = rams, battery = batterys, front_camera = front_cameras, back_camera = back_cameras, processor = processors, android = androids, network = networks, quantity = quantitys, warranty = warrantys, date = dates };
                context.mobildetailes.Add(dataobject);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public void additmexist(string nms, double prices, double screens, int storages, int rams, int batterys, int front_cameras, int back_cameras, string processors, string androids, string networks, int quantitys, double warrantys, string dates)
        {
            var datashow = context.mobildetailes.Where(n => n.name == nms).Select(n => n.name).FirstOrDefault();
            if (datashow != null)
            {
                int q = context.mobildetailes.Where(n => n.name == nms).Select(n => n.quantity).FirstOrDefault();
                int newquantity = q + quantitys;
                int indexrow = context.mobildetailes.Where(m => m.name == nms).Select(m => m.id).FirstOrDefault();
                mobildetaile dataobject = new mobildetaile() { id = indexrow, name = nms, price = prices, screen = screens, storage = storages, ram = rams, battery = batterys, front_camera = front_cameras, back_camera = back_cameras, processor = processors, android = androids, network = networks, quantity = newquantity, warranty = warrantys, date = dates };
                context.Entry(dataobject).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
        #endregion

        ///function to update searched item
        #region update function
        public bool update(string nms, double prices, double screens, int storages, int rams, int batterys, int front_cameras, int back_cameras, string processors, string androids, string networks, int quantitys, double warrantys, string dates)
        {
            try
            {
                int indexrow = context.mobildetailes.Where(m => m.name == nms).Select(m => m.id).FirstOrDefault();
                mobildetaile dataobject = new mobildetaile() { id = indexrow, name = nms, price = prices, screen = screens, storage = storages, ram = rams, battery = batterys, front_camera = front_cameras, back_camera = back_cameras, processor = processors, android = androids, network = networks, quantity = quantitys, warranty = warrantys, date = dates };
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

using So_Do_Tu_Duy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_Do_Tu_Duy.Controller
{
    public class TextController
    {
        public static bool AddText(Infor tx)
        {
            using ( var _context = new DBMindMapEntities() )
            {
                try
                {
                    _context.Infors.AddOrUpdate(tx);
                    _context.SaveChanges();
                    return true;
                }
                catch (DbEntityValidationException e)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        sb.AppendLine(string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                                        eve.Entry.Entity.GetType().Name,
                                                        eve.Entry.State));
                        foreach (var ve in eve.ValidationErrors)
                        {
                            sb.AppendLine(string.Format("- Property: \"{0}\", Error: \"{1}\"",
                                                        ve.PropertyName,
                                                        ve.ErrorMessage));
                        }
                    }
                    throw new DbEntityValidationException(sb.ToString(), e);
                }

            }    
        }

        public static Infor getInfor(int id)
        {
            using ( var _context = new DBMindMapEntities() )
            {
                var x = (from i in _context.Infors
                         where i.ID == id
                         select i).SingleOrDefault();
                return x;
            }           
        }


    }
}
